using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace mwt
{
    public class auto_locker : IDisposable
    {
        private Object m_obj = null;
        private bool m_is_locked = false;
        public auto_locker(Object obj, int tick = 1)
        {
            m_obj = obj;
            Lock(tick);
        }
        public void Dispose()
        {
            if (m_is_locked)
            {
                Release();
            }
            m_obj = null;
        }

        public void Release()
        {
            Monitor.Exit(m_obj);
            m_is_locked = false;
        }

        public void Lock(int tick)
        {
            if (m_is_locked)
                return ;
            while(null != m_obj)
            {
                if (Monitor.TryEnter(m_obj, tick))
                {
                    m_is_locked = true;
                    break;
                }
            }
        }
    }
}
