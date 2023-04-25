using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mwt
{
    public abstract class scriptobject
    {
        public abstract script_function get_function(string func_name);

        public abstract R get_value<R>(string key);

        public abstract R get_value<R>(int index);

        public abstract void set_value<T>(string key, T value);

        public abstract void set_value<T>(int index, T value);

        public R invoke<R>(string func_name)
        {
            script_function func = get_function(func_name);
            if (null == func)
                return default(R);
            return func.invoke<R>();
        }

        public R invoke<R, T>(string func_name, T arg)
        {
            script_function func = get_function(func_name);
            if (null == func)
                return default(R);
            return func.invoke<R, T>(arg);
        }

        public R invoke<R, T1, T2>(string func_name, T1 arg1, T2 arg2)
        {
            script_function func = get_function(func_name);
            if (null == func)
                return default(R);
            return func.invoke<R, T1, T2>(arg1, arg2);
        }

        public R invoke<R, T1, T2, T3>(string func_name, T1 arg1, T2 arg2, T3 arg3)
        {
            script_function func = get_function(func_name);
            if (null == func)
                return default(R);
            return func.invoke<R, T1, T2, T3>(arg1, arg2, arg3);
        }

        public R invoke<R, T1, T2, T3, T4>(string func_name, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            script_function func = get_function(func_name);
            if (null == func)
                return default(R);
            return func.invoke<R, T1, T2, T3, T4>(arg1, arg2, arg3, arg4);
        }

        public R invoke<R, T1, T2, T3, T4, T5>(string func_name, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            script_function func = get_function(func_name);
            if (null == func)
                return default(R);
            return func.invoke<R, T1, T2, T3, T4, T5>(arg1, arg2, arg3, arg4, arg5);
        }

        public void call(string func_name)
        {
            script_function func = get_function(func_name);
            if (null == func)
                return ;
            func.call();
        }

        public void call<T>(string func_name, T arg)
        {
            script_function func = get_function(func_name);
            if (null == func)
                return;
            func.call(arg);
        }

        public void call<T1, T2>(string func_name, T1 arg1, T2 arg2)
        {
            script_function func = get_function(func_name);
            if (null == func)
                return;
            func.call(arg1, arg2);
        }

        public void call<T1, T2, T3>(string func_name, T1 arg1, T2 arg2, T3 arg3)
        {
            script_function func = get_function(func_name);
            if (null == func)
                return;
            func.call(arg1, arg2, arg3);
        }

        public void call<T1, T2, T3, T4>(string func_name, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            script_function func = get_function(func_name);
            if (null == func)
                return;
            func.call(arg1, arg2, arg3, arg4);
        }

        public void call<T1, T2, T3, T4, T5>(string func_name, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            script_function func = get_function(func_name);
            if (null == func)
                return;
            func.call(arg1, arg2, arg3, arg4, arg5);
        }
    }
}
