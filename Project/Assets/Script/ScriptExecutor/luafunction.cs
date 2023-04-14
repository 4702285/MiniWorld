using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LuaInterface;

namespace mwt
{
    public class luafunction : script_function
    {
        private LuaFunction m_func;

        public luafunction(LuaFunction f)
        {
            m_func = f;
        }

        public override void call(){ if (null != m_func) { m_func.Call(); } }
        public override void call<T>(T arg) { if (null != m_func) { m_func.Call(arg); } }
        public override void call<T1,T2>(T1 arg1, T2 arg2) { if (null != m_func) { m_func.Call(arg1, arg2); } }
        public override void call<T1,T2,T3>(T1 arg1, T2 arg2, T3 arg3) { if (null != m_func) { m_func.Call(arg1, arg2, arg3); } }
        public override void call<T1, T2, T3, T4>(T1 arg1, T2 arg2, T3 arg3, T4 arg4) { if (null != m_func) { m_func.Call(arg1, arg2, arg3, arg4); } }
        public override void call<T1, T2, T3, T4, T5>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { if (null != m_func) { m_func.Call(arg1, arg2, arg3, arg4, arg5); } }
        public override R invoke<R>() 
        {
            if (null == m_func) 
            {
                throw new LuaException("invalid lua function.");
            } 
            return m_func.Invoke<R>(); 
        }
        public override R invoke<R, T>(T arg)
        { 
            if (null == m_func) 
            { 
                throw new LuaException("invalid lua function."); 
            }
            return m_func.Invoke<T,R>(arg); 
        }
        public override R invoke<R, T1, T2>(T1 arg1, T2 arg2)
        {
            if (null == m_func)
            {
                throw new LuaException("invalid lua function.");
            }
            return m_func.Invoke<T1, T2, R>(arg1, arg2);
        }

        public override R invoke<R, T1, T2, T3>(T1 arg1, T2 arg2, T3 arg3)
        {
            if (null == m_func)
            {
                throw new LuaException("invalid lua function.");
            }
            return m_func.Invoke<T1, T2, T3, R>(arg1, arg2, arg3);
        }

        public override R invoke<R, T1, T2, T3, T4>(T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            if (null == m_func)
            {
                throw new LuaException("invalid lua function.");
            }
            return m_func.Invoke<T1, T2, T3, T4, R>(arg1, arg2, arg3, arg4);
        }

        public override R invoke<R, T1, T2, T3, T4, T5>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            if (null == m_func)
            {
                throw new LuaException("invalid lua function.");
            }
            return m_func.Invoke<T1, T2, T3, T4, T5, R>(arg1, arg2, arg3, arg4, arg5);
        }

    }
}
