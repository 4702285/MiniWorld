using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace mwt
{
    public abstract class resloader : work_item
    {
        public const int NONE = 0;
        public const int INITED = 1;
        public const int LOADING = 2;
        public const int LOADED = 3;
        public const int RECYCLED = 4;

        private int m_refcount = 0;
        private int m_priority;
        private int m_state = 0;
        protected string m_url;
        protected Type m_type;
        protected List<KeyValuePair<callback_load,object>> m_callbacks;
        protected object m_param;
        protected object m_obj;

        public override int priority
        {
            get { return m_priority; }
            set {
                m_priority = value;
                main_application.inst.resource.change_priority(this);
            }
        }

        public int state
        {
            get { return m_state; }
        }

        public string url
        {
            get { return m_url; }
        }

        public resloader(string url, int prio, Type type, callback_load cb, object param)
        {
            m_url = url;
            m_priority = prio;
            m_type = type;
            if (null != cb)
            {
                m_callbacks = new List<KeyValuePair<callback_load,object>>() { new KeyValuePair<callback_load,object>( cb, param ) };
            }
            m_state = INITED;
        }

        protected void invoke_callbacks()
        {
            for(int index = 0; index < m_callbacks.Count; ++ index)
            {
                if (null == m_callbacks[index].Key)
                    continue;
                m_callbacks[index].Key.Invoke(m_url, m_obj, m_callbacks[index].Value);
            }
        }

        public void add_callback(callback_load cb, object param)
        {
            m_callbacks.Add(new KeyValuePair<callback_load, object>(cb, param));
        }

        public override void done()
        {
            invoke_callbacks();
            m_state = LOADED;
        }

        public int add_reference()
        {
            return ++m_refcount;
        }

        public void load(int prio, callback_load cb, object param)
        {
            if (state == LOADED)
            {
                cb.Invoke(m_url, m_obj, param);
                return;
            }

            if (state == INITED || state == LOADING)
            {
                add_callback(cb, param);
                if (prio > priority)
                {
                    priority = prio;
                }
            }
        }

        public int release()
        {
            if (m_refcount > 0)
            {
                --m_refcount;
                if (m_refcount > 0)
                    return m_refcount;
            }

            on_recycle();

            return 0;
        }

        protected void on_recycle()
        {
            m_state = RECYCLED;
        }

        protected void on_start()
        {
            m_state = LOADING;
        }
    }
}
