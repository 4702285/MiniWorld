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
        private bool m_locked = false;
        public auto_locker(Object obj, int tick = 1)
        {
            m_obj = obj;
            lock_impl(tick);
        }

        ~auto_locker()
        {
            Dispose(false);
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (m_locked && null != m_obj)
            {
                Monitor.Exit(m_obj);
            }
            m_obj = null;
            m_locked = false;
        }

        public void release()
        {
        }

        public void lock_impl(int tick)
        {
            if (m_locked)
                return ;
            while(null != m_obj)
            {
                if (Monitor.TryEnter(m_obj, tick))
                {
                    m_locked = true;
                    break;
                }
            }
        }
    }
}
