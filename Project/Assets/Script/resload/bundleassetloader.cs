using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace mwt
{
    class bundleassetloader: resloader
    {
        private bundleloader m_bundle;
        private AssetBundleRequest m_request;
        public bundleassetloader(string uri, int prio, Type type, callback_load cb, object param)
            :base(uri,prio,type,cb,param)
        {

        }

        public override void start()
        {
            on_start();
            resourceloader resmgr = main_application.inst.resource;
            string bundle_uri = resmgr.get_bundle(m_url);
            m_bundle = resmgr.load_bundle(bundle_uri, priority + 1, on_bundle_loaded, this);
            if (null  == m_bundle)
            {
                Log.error("{0} : invalid bundle,", m_url);
                return;
            }
            m_bundle.add_reference();
            if (!m_bundle.is_done())
                m_bundle.start();
            else
                on_bundle_loaded(bundle_uri, m_bundle, this);
         }

        private void on_bundle_loaded(string url, object obj, object param)
        {
            bundleloader bundle = obj as bundleloader;
            if (null == bundle || null == bundle.bundle)
            {
                Log.error("{0} : load asset bundle failed.", url);
                return;
            }
            m_request = m_bundle.bundle.LoadAssetAsync(m_url);
        }

        public override bool is_done()
        {
            if (state == LOADED)
                return true;
            if (state != LOADING)
                return false;

            if (null == m_bundle)
                return true;
            if (!m_bundle.is_done())
                return false;

            if (null == m_request)
                return true;
            return m_request.isDone;
        }

        public override void done()
        {
            m_obj = m_request.asset;
            base.done();
        }
    }
}
