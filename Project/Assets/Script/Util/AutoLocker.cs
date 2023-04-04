using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace mwt
{
    public class AutoLocker : IDisposable
    {
        private Object mObj = null;
        private bool mIsLocked = false;
        public AutoLocker(Object obj, int tick = 1)
        {
            mObj = obj;
            Lock(tick);
        }
        public void Dispose()
        {
            if (mIsLocked)
            {
                Release();
            }
            mObj = null;
        }

        public void Release()
        {
            Monitor.Exit(mObj);
            mIsLocked = false;
        }

        public void Lock(int tick)
        {
            if (mIsLocked)
                return ;
            while(null != mObj)
            {
                if (Monitor.TryEnter(mObj, tick))
                {
                    mIsLocked = true;
                    break;
                }
            }
        }
    }
}
