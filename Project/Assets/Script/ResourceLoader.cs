using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System.IO;
using System;
using LitJson;
using LuaInterface;
using System.Text;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace mwt
{
    public delegate void callback_load(string path, object obj, object param);
    //public delegate bool callback_loadasset(string path, UnityEngine.Object asset, object param);
    //public delegate void callback_bundle(string uri, bundleloader bundle, object param);

    public class resourceloader
    {
        [NoToLua]
        public const int FROM_DATABASE = 0;
        [NoToLua]
        public const int FROM_BUNDLE = 1;

        [NoToLua]
        public const int PRIO_IMM = 1000;
        [NoToLua]
        public const int PRIO_ENTITY = 200;

        private const string bundleasset_path = "BundleAssets.json";
        private const string assetbundle_path = "AssetBundle";

        private delegate bool asset_loader(string path, int priority, Type type, callback_load cb, object param);

        private asset_loader[] m_loader = null;
        private Dictionary<string, string> m_asset_bundles;
        private AssetBundleManifest m_bundle_config;
        private Dictionary<string, resloader> m_loadermap;
        private List<work_item> m_queue = new List<work_item>();
        private List<work_item> m_running = new List<work_item>();
        private int m_run_count = 2;
#if UNITY_EDITOR
        private int m_mode = FROM_DATABASE;
#else
        private int m_mode = FROM_BUNDLE;
#endif
        private bool m_inited = false;

        [NoToLua]
        public bool init()
        {
            m_loader = new asset_loader[]
            {
                load_from_databse,
                load_from_bundle
            };
            m_loadermap = new Dictionary<string, resloader>();
            if (exists(bundleasset_path))
                load_stream(bundleasset_path, PRIO_IMM, on_assetbundle_loaded, this);
            if (exists(assetbundle_path))
                main_application.inst.StartCoroutine(load_bundleconfig(assetbundle_path));
            m_inited = false;
            return true;
        }

        public bool exists(string url)
        {
            return File.Exists(Path.Combine(Application.streamingAssetsPath,url));
        }

        [NoToLua]
        public void update()
        {
            update_running();
            update_queue();
        }

        [NoToLua]
        public bool load_stream(string uri, int prio, callback_load cb, object param)
        {
            resloader loader;
            if (m_loadermap.TryGetValue(uri, out loader))
            {
                loader.load(prio, cb, param);
                return true;
            }
            add(new binaryloader(uri, prio, cb, param));
            return true;
        }

        [NoToLua]
        public bool load_asset(string uri, int prio, Type type, callback_load cb, object param)
        {
            if (null == m_loader || null == m_loader[m_mode])
                return false;
            m_loader[m_mode](uri, prio, type, cb, param);
            return true;
        }

        [NoToLua]
        public bundleloader load_bundle(string uri, int prio, callback_load cb, object param)
        {
            resloader loader;
            if (m_loadermap.TryGetValue(uri, out loader))
            {
                loader.load(prio, cb, param);
                return loader as bundleloader;
            }
            bundleloader b_loader = new bundleloader(uri, prio, cb, param);
            add(b_loader);
            return b_loader;
        }

        [NoToLua]
        public string get_bundle(string url)
        {
            if (null == m_asset_bundles)
                return null;
            string bundle;
            if (!m_asset_bundles.TryGetValue(url, out bundle))
                return null;
            return bundle;
        }

        [NoToLua]
        public string [] get_depend_bundles(string url)
        {
            if (null == m_bundle_config)
                return null;
            return m_bundle_config.GetDirectDependencies(url);
        }

        public bool load_asset(string uri, int prio, Type type, LuaFunction cb, long param)
        {
            return load_asset(uri, prio, type, (path, obj, param) =>
            {
                if (null != cb)
                {
                    try
                    {
                        cb.Call(path, obj, (long)param);
                    }
                    catch (Exception ex)
                    {
                        Log.exception(ex);
                    }
                }
            }, param);
        }


        private bool load_from_databse(string uri, int priority, Type type, callback_load cb, object param)
        {
            resloader loader;
            if (m_loadermap.TryGetValue(uri, out loader))
            {
                loader.load(priority, cb, param);
                return true;
            }
#if UNITY_EDITOR
            add(new database_loader(uri, priority, type, cb, param));
#endif
            return true;
        }

        private bool load_from_bundle(string uri, int priority, Type type, callback_load cb, object param)
        {
            resloader loader;
            if (m_loadermap.TryGetValue(uri, out loader))
            {
                loader.load(priority, cb, param);
                return true;
            }
            add(new bundleassetloader(uri, priority, type, cb, param));
            return true;
        }

        private void update_running()
        {
            if (m_running.Count == 0)
                return;
            work_item item;
            for(int index = 0; index < m_running.Count; )
            {
                item = m_running[index];
                if (!item.is_done())
                {
                    ++index;
                    continue;
                }
                item.done();
                m_running.RemoveAt(index);
            }
        }

        private void update_queue()
        {
            if (m_queue.Count == 0)
                return;
            while(m_running.Count < m_run_count && m_queue.Count > 0)
            {
                work_item item = pop_queue();
                if (null == item)
                    break;
                item.start();
                m_running.Add(item);
            }
        }

        private work_item pop_queue()
        {
            work_item ret = m_queue[0];
            m_queue[0] = m_queue[m_queue.Count - 1];
            m_queue.RemoveAt(m_queue.Count - 1);
            resort();
            return ret;
        }

        private void resort()
        {
            int pos = 0;
            work_item cur = m_queue[pos];
            while(m_queue.Count > pos * 2 + 1)
            {
                work_item lh = m_queue[pos * 2 + 1];
                if (m_queue.Count <= pos*2+2)
                {
                    if (cur.priority < lh.priority)
                    {
                        m_queue[pos] = lh;
                        m_queue[pos * +1] = cur;
                    }
                    break;
                }
                work_item rh = m_queue[pos * 2 + 2];
                if (cur.priority >= lh.priority && cur.priority >= rh.priority)
                {
                    break;
                }
                else if (cur.priority >= rh.priority || lh.priority >= rh.priority)
                {
                    m_queue[pos] = lh;
                    pos = pos * 2 + 1;
                }
                else
                {
                    m_queue[pos] = rh;
                    pos = pos * 2 + 2;
                }
                m_queue[pos] = cur;
            }
        }

        [NoToLua]
        private void add(resloader item)
        {
            if (m_queue.Count == 0 && m_running.Count < m_run_count)
            {
                item.start();
                m_running.Add(item);
                return;
            }

            int pos = m_queue.Count;
            m_queue.Add(item);
            m_loadermap.Add(item.url, item);
            raise(pos);
        }

        [NoToLua]
        public void change_priority(work_item item)
        {
            int pos = -1;
            for (int index = 0; index < m_queue.Count; ++index)
            {
                if (m_queue[index] == item)
                {
                    pos = index;
                    break;
                }
            }

            if (pos < 0)
                return;
            raise(pos);
        }

        private void raise(int pos)
        {
            work_item item = m_queue[pos];
            while (pos > 0)
            {
                if (item.priority <= m_queue[(pos - 1) / 2].priority)
                    break;
                m_queue[pos] = m_queue[(pos - 1) / 2];
                m_queue[(pos - 1) / 2] = item;
                pos = (pos - 1) / 2;
            }

        }

        private void on_assetbundle_loaded(string url, object obj, object param)
        {
            m_asset_bundles = new Dictionary<string, string>();
            byte[] data = obj as byte[];
            if (null == data || data.Length == 0)
            {
                Log.error("{0} : load asset bundles failed.", url);
                return;
            }
            JsonData root = JsonMapper.ToObject(Encoding.UTF8.GetString(data));
            if (null == root)
            {
                Log.error("{0} : load json failed.", url);
                return;
            }
            for (int index = 0; index < root.Count; ++index)
            {
                string bundle = (string)root[index]["bundle"];
                JsonData assets = root[index]["asset"];
                for (int pos = 0; pos < assets.Count; ++pos)
                {
                    m_asset_bundles.Add((string)assets[pos], bundle);
                }
            }
            m_inited = m_bundle_config != null;
        }

        private IEnumerator load_bundleconfig(string url)
        {
            string full_path = path_util.bundle_path(url);
            UnityWebRequest request = UnityWebRequest.Get(full_path);
            if (null == request)
            {
                Log.error("{0} : invalid bundle.", full_path);
                yield break;
            }

            DownloadHandlerAssetBundle handle = new DownloadHandlerAssetBundle(request.url, uint.MaxValue);
            yield return request.SendWebRequest();
            m_bundle_config = handle.assetBundle.LoadAsset<AssetBundleManifest>(url);
            if (null == m_bundle_config)
            {
                Log.error("{0} : invalid bundle asset.", url);
                yield break;
            }
            m_inited = m_asset_bundles != null;
        }

    }
}

