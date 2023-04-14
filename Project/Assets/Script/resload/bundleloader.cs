using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;

namespace mwt
{
    public class bundleloader : resloader
    {
        AssetBundle m_bundle;
        UnityWebRequest m_request;
        DownloadHandlerAssetBundle m_handle;
        List<bundleloader> m_depends;

        public AssetBundle bundle
        {
            get { return m_bundle; }
        }

        public bundleloader(string uri, int prio, callback_load cb, object param):base(uri,prio,typeof(AssetBundle),null, null)
        {
            add_callback(cb, this);
        }

        public override void start()
        {
            on_start();
            resourceloader res = main_application.inst.resource;
            string[] bundles = res.get_depend_bundles(m_url);
            if (null != bundles && bundles.Length > 0)
            {
                m_depends = new List<bundleloader>();
                for(int index = 0; index < bundles.Length; ++index)
                {
                    bundleloader bundle = res.load_bundle(bundles[index], priority + 1, on_depend_loaded, this);
                    m_depends.Add(bundle);
                    bundle.start();
                }
            }
            if (is_depend_loaded())
                load_bundle();
        }

        private bool is_depend_loaded()
        {
            if (m_depends == null || m_depends.Count == 0)
                return true;
            for(int index = 0; index < m_depends.Count; ++index)
            {
                if (!m_depends[index].is_done())
                    return false;
            }
            return true;
        }

        private void on_depend_loaded(string uri, object obj, object param)
        {
            if (!is_depend_loaded())
                return;
            load_bundle();
        }

        private void load_bundle()
        {
            string full_path = path_util.bundle_path(m_url);
            m_request = UnityWebRequest.Get(full_path);
            if (null == m_request)
            {
                Log.error("{0} : Invalid asset bundle.", full_path);
                return;
            }
            uint crc = uint.MaxValue;
            m_handle = new DownloadHandlerAssetBundle(m_request.url, crc);
            m_request.SendWebRequest();
        }

        public override bool is_done()
        {
            if (state == LOADED)
                return true;
            if (state != LOADING)
                return false;

            if (!is_depend_loaded())
                return false;
            return m_request==null || m_request.isDone;
        }

        public override void done()
        {
            m_obj = (null != m_handle) ? m_handle.assetBundle : null;
            base.done();
            m_request = null;
            m_handle = null;
        }
    }
}
