using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

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
            on_start();
            m_obj = AssetDatabase.LoadAssetAtPath(m_url, m_type);
        }

        public override bool is_done()
        {
            return (state == LOADING || state == LOADED);
        }
    }
}
