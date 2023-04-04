using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System.IO;

public class ResourceLoader
{
    public delegate bool LoadCallback(string path, DownloadHandler handler, object param);

    public bool Load(string uri, LoadCallback cb, object param)
    {
        MainApplication.Inst.StartCoroutine(LoadAsset(uri, cb, param));
        return true;
    }

    public IEnumerator LoadAsset(string uri, LoadCallback cb, object param)
    {
        string full_path = Path.Combine(Application.streamingAssetsPath, uri);
        UnityWebRequest request = UnityWebRequest.Get(full_path);
        yield return request.SendWebRequest();
        if (null != cb)
        {
            cb(uri, request.downloadHandler, param);
        }
    }

}
