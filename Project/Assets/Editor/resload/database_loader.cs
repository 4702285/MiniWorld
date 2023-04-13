using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace mwt
{
    public class database_loader : resloader
    {
        public database_loader(string uri, int prio, Type type, callback_load cb, object param):
            base(uri,prio, type, cb, param)
        {
        }

        public override void start()
        {
#if UNITY_EDITOR
            m_obj = AssetDatabase.LoadAssetAtPath(m_url, m_type);
#endif
        }

        public override bool is_done()
        {
            return true;
        }
    }
}
