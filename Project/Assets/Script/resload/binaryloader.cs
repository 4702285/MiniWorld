using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;

namespace mwt
{
    class binaryloader : resloader
    {
        private UnityWebRequest m_request;

        public binaryloader(string url, int prio, callback_load cb, object param):base(url, prio, null, null, null)
        {
            add_callback(cb, this);
        }

        public override bool is_done()
        {
            if (state != LOADING && state != LOADED)
                return false;
            return state == LOADED || m_request == null || m_request.isDone;
        }

        public override void start()
        {
            on_start();
            string full_path = Path.Combine(Application.streamingAssetsPath, m_url);
            m_request = UnityWebRequest.Get(full_path);
            if (null == m_request)
                return;
            m_request.SendWebRequest();
        }

        public override void done()
        {
            m_obj = m_request.downloadHandler.data;
            base.done();
        }
 
    }
}
