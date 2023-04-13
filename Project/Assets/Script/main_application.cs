using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using LitJson;
using System.Text;
using System.IO;
using mwt;
using LuaInterface;

public class main_application : MonoBehaviour
{
    private static main_application __inst = null;

    public static main_application inst
    {
        get
        {
            if (null == __inst)
            {
                GameObject go = new GameObject("MainGame", typeof(main_application));
            }
            return __inst;

        }
    }

    private resourceloader m_resloader;
    private script_factory m_script_factory;
    private value_parser m_parser = new value_parser();
    private mwt.Log mLogger = new mwt.Log();

    private Dictionary<string, string> m_env_variables = new Dictionary<string, string>();

    public resourceloader resource
    {
        get { return m_resloader; }
    }

    public value_parser parser
    {
        get { return m_parser; }
    }

    [NoToLua]
    public Log Log
    {
        get { return mLogger; }
    }

    private bool Init()
    {
        m_resloader = new resourceloader();
        if (!m_resloader.init())
            return false;

        if (!m_resloader.load_stream("config.json", resourceloader.PRIO_IMM, on_config_loaded, this))
            return false;
        m_env_variables.Add("StreamingAssets", Application.streamingAssetsPath);
        m_env_variables.Add("DataPath", Application.dataPath);
        m_env_variables.Add("PersistentPath", Application.persistentDataPath);
        string project_path = mwt.path_util.trim_sep_end(Path.GetDirectoryName(Application.dataPath));
        m_env_variables.Add("ProjectPath", project_path);
        m_env_variables.Add("RootPath", mwt.path_util.trim_sep_end(Path.GetDirectoryName(project_path)));

        m_script_factory = new script_factory();
        m_script_factory.init("script.json");


        return true;
    }

    private void Awake()
    {
        if (null == __inst)
        {
            gameObject.hideFlags = HideFlags.HideAndDontSave;
            DontDestroyOnLoad(gameObject);
            __inst = this;
            __inst.Init();
        }
    }

    private void on_config_loaded(string uri, object obj, object param)
    {
        byte[] data = obj as byte[];
        if (null == data || data.Length == 0)
        {
            Debug.LogErrorFormat("{0} : load application configuration failed.", uri);
            return ;
        }
        JsonData config = JsonMapper.ToObject(Encoding.UTF8.GetString(data));
        if (null == config)
        {
            Debug.LogErrorFormat("{0} : Application configuration syntex is invalid.", uri);
            return ;
        }
        if (config.ContainsKey("variable"))
        {
            init_env_variables(config["variable"]);
        }

        string start = parser.get_variable("START_SCRIPT");
        if (!string.IsNullOrEmpty(start))
        {
            m_script_factory.run(start);
        }

    }

    private bool init_env_variables(JsonData var_list)
    {
        if (!var_list.IsObject)
            return false;

        foreach(string key in var_list.Keys)
        {
            m_env_variables.Add(key, (string)var_list[key]);
        }
        return true;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        m_resloader.update();
    }

    public string get_variable(string name)
    {
        string value;
        if (m_env_variables.TryGetValue(name, out value))
            return value;
        return null;
    }
}
