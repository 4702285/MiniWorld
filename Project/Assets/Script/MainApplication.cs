using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using LitJson;
using System.Text;
using System.IO;
using EnvVar;

public class MainApplication : MonoBehaviour
{
    private static MainApplication __inst = null;

    public static MainApplication Inst
    {
        get
        {
            if (null == __inst)
            {
                GameObject go = new GameObject("MainGame", typeof(MainApplication));
            }
            return __inst;

        }
    }

    private ResourceLoader mResLoader;
    private ScriptFactory mScriptFactory;
    private ValueParser mVP = new ValueParser();
    private mwt.Log mLogger = new mwt.Log();

    private Dictionary<string, string> mEnvirVariables = new Dictionary<string, string>();

    public ResourceLoader Resource
    {
        get { return mResLoader; }
    }

    public ValueParser ValueParser
    {
        get { return mVP; }
    }

    public mwt.Log Log
    {
        get { return mLogger; }
    }

    private bool Init()
    {
        mResLoader = new ResourceLoader();

        if (!Resource.Load("config.json", OnConfigLoaded, this))
            return false;
        mEnvirVariables.Add("StreamingAssets", Application.streamingAssetsPath);
        mEnvirVariables.Add("DataPath", Application.dataPath);
        mEnvirVariables.Add("PersistentPath", Application.persistentDataPath);
        string project_path = mwt.PathUtil.TrimSepEnd(Path.GetDirectoryName(Application.dataPath));
        mEnvirVariables.Add("ProjectPath", project_path);
        mEnvirVariables.Add("RootPath", mwt.PathUtil.TrimSepEnd(Path.GetDirectoryName(project_path)));

        mScriptFactory = new ScriptFactory();
        mScriptFactory.Init("script.json");


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

    private bool OnConfigLoaded(string uri, DownloadHandler h, object param)
    {
        if (!h.isDone)
        {
            Debug.LogErrorFormat("{0} : load application configuration failed.", uri);
            return true;
        }
        JsonData config = JsonMapper.ToObject(h.text);
        if (null == config)
        {
            Debug.LogErrorFormat("{0} : Application configuration syntex is invalid.", uri);
            return true;
        }
        if (config.ContainsKey("variable"))
        {
            InitEnvironmentVariables(config["variable"]);
        }

        string start = ValueParser.GetVariable("START_SCRIPT");
        if (!string.IsNullOrEmpty(start))
        {
            mScriptFactory.Run(start);
        }

        return true;
    }

    private bool InitEnvironmentVariables(JsonData var_list)
    {
        if (!var_list.IsObject)
            return false;

        foreach(string key in var_list.Keys)
        {
            mEnvirVariables.Add(key, (string)var_list[key]);
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
        
    }

    public string GetVariable(string name)
    {
        string value;
        if (mEnvirVariables.TryGetValue(name, out value))
            return value;
        return null;
    }
}
