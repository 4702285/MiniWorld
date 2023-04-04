using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using System.IO;
using LitJson;
using mwt;

class ScriptFactory
{
    class ExecutorDesc
    {
        public string name;
        public List<string> extension;
        public string executor;
    }
    class ExecutorInfo
    {
        public ExecutorDesc desc;
        public Type type;
        public IScriptExecutor executor;
    };

    // 执行器表
    private Dictionary<string, ExecutorInfo> mExecutors = new Dictionary<string, ExecutorInfo>();
    // 对象是否初始化完成
    private bool mInitialized = false;
    // 缓存脚本
    private List<string> mCached = new List<string>();

    public bool LoadConfig(string url)
    {
        mInitialized = false;
        return MainApplication.Inst.Resource.Load(url, (path, handler, param)=> {
            if (null == handler || !handler.isDone)
                return true;
            ScriptFactory _this = param as ScriptFactory;
            JsonData config = JsonMapper.ToObject(handler.text);
            Dictionary<string, ExecutorInfo> executors = new Dictionary<string, ExecutorInfo>();
            foreach(JsonData item in config)
            {
                ExecutorDesc desc = new ExecutorDesc();
                desc.name = (string)item["name"];
                desc.executor = (string)item["executor"];
                desc.extension = new List<string>();
                foreach (JsonData ext in item["extension"]) { desc.extension.Add((string)ext); }
                ExecutorInfo info = new ExecutorInfo();
                info.desc = desc;
                info.type = Type.GetType(desc.executor);
                if (null == info.type)
                    continue;
                executors.Add(info.desc.name, info);
            }
            _this.mExecutors = executors;
            _this.mInitialized = true;
            while(_this.mCached.Count > 0)
            {
                _this.Run(mCached[0]);
                mCached.RemoveAt(0);
            }
            return true;
        }, this);
    }

    public bool Init(string uri)
    {
        return LoadConfig(uri);
    }

    public bool Run(string uri)
    {
        if (!mInitialized)
        {
            mCached.Add(uri);
            return true;
        }
        ExecutorInfo exec = GetExecutor(uri);
        if (null == exec)
        {
            Log.error("{0}: not fount exexutor.",uri);
            return false;
        }
        if (null == exec.executor)
        {
            if (!InitExecutor(exec))
                return false;
        }
        return exec.executor.Run(uri);
    }

    private ExecutorInfo GetExecutor(string uri)
    {
        string ext = Path.GetExtension(uri).ToLower();
        foreach(KeyValuePair<string, ExecutorInfo> kv in mExecutors)
        {
            if (kv.Value.desc.extension.Contains(ext))
            {
                return kv.Value;
            }
        }
        return null;
    }

    private bool InitExecutor(ExecutorInfo exec)
    {
        exec.executor = exec.type.Assembly.CreateInstance(exec.desc.executor) as IScriptExecutor;
        if (null == exec.executor)
            return false;
        return exec.executor.Init();
    }
}
