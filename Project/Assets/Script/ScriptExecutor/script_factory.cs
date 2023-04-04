using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using System.IO;
using LitJson;
using mwt;

class script_factory
{
    class executor_desc
    {
        public string name;
        public List<string> extension;
        public string executor;
    }
    class executor_info
    {
        public executor_desc desc;
        public Type type;
        public script_executor executor;
    };

    // 执行器表
    private Dictionary<string, executor_info> mExecutors = new Dictionary<string, executor_info>();
    // 对象是否初始化完成
    private bool mInitialized = false;
    // 缓存脚本
    private List<string> mCached = new List<string>();

    public bool LoadConfig(string url)
    {
        mInitialized = false;
        return main_application.inst.Resource.Load(url, (path, handler, param)=> {
            if (null == handler || !handler.isDone)
                return true;
            script_factory _this = param as script_factory;
            JsonData config = JsonMapper.ToObject(handler.text);
            Dictionary<string, executor_info> executors = new Dictionary<string, executor_info>();
            foreach(JsonData item in config)
            {
                executor_desc desc = new executor_desc();
                desc.name = (string)item["name"];
                desc.executor = (string)item["executor"];
                desc.extension = new List<string>();
                foreach (JsonData ext in item["extension"]) { desc.extension.Add((string)ext); }
                executor_info info = new executor_info();
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
        executor_info exec = GetExecutor(uri);
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
        return exec.executor.run(uri);
    }

    private executor_info GetExecutor(string uri)
    {
        string ext = Path.GetExtension(uri).ToLower();
        foreach(KeyValuePair<string, executor_info> kv in mExecutors)
        {
            if (kv.Value.desc.extension.Contains(ext))
            {
                return kv.Value;
            }
        }
        return null;
    }

    private bool InitExecutor(executor_info exec)
    {
        exec.executor = exec.type.Assembly.CreateInstance(exec.desc.executor) as script_executor;
        if (null == exec.executor)
            return false;
        return exec.executor.init();
    }
}
