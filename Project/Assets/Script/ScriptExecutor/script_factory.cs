using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using System.IO;
using LitJson;
using mwt;

public class script_factory
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
    private Dictionary<string, executor_info> m_executors = new Dictionary<string, executor_info>();
    // 对象是否初始化完成
    private bool m_initialized = false;
    // 缓存脚本
    private List<string> m_cached = new List<string>();

    public bool loadconfig(string url)
    {
        m_initialized = false;
        return main_application.inst.resource.load_stream(url, resourceloader.PRIO_IMM, (path, obj, param)=> {
            byte[] data = obj as byte[];
            if (null == data || data.Length == 0)
                return ;
            script_factory _this = param as script_factory;
            JsonData config = JsonMapper.ToObject(Encoding.UTF8.GetString(data));
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
            _this.m_executors = executors;
            _this.m_initialized = true;
            while(_this.m_cached.Count > 0)
            {
                _this.run(m_cached[0]);
                m_cached.RemoveAt(0);
            }
        }, this);
    }

    public bool init(string uri)
    {
        return loadconfig(uri);
    }

    public bool run(string uri)
    {
        if (!m_initialized)
        {
            m_cached.Add(uri);
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

    public scriptobject get_object(string name)
    {
        if (!m_initialized)
            return null;
        scriptobject obj;
        foreach(KeyValuePair<string,executor_info> kv in m_executors)
        {
            if (null == kv.Value)
                continue;
            obj = kv.Value.executor.get(name);
            if (null != obj)
                return obj;
        }
        return null;
    }

    private executor_info GetExecutor(string uri)
    {
        string ext = Path.GetExtension(uri).ToLower();
        foreach(KeyValuePair<string, executor_info> kv in m_executors)
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
