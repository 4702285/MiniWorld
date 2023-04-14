using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mwt
{
    public abstract class script_function
    {
        public abstract R invoke<R>();

        public abstract R invoke<R, T>(T arg1);

        public abstract R invoke<R, T1, T2>(T1 arg1, T2 arg2);

        public abstract R invoke<R, T1, T2, T3>(T1 arg1, T2 arg2, T3 arg3);

        public abstract R invoke<R, T1, T2, T3, T4>(T1 arg1, T2 arg2, T3 arg3, T4 arg4);

        public abstract R invoke<R, T1, T2, T3, T4, T5>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);

        public abstract void call();

        public abstract void call<T>(T arg);

        public abstract void call<T1, T2>(T1 arg, T2 arg2);

        public abstract void call<T1, T2, T3>(T1 arg1, T2 arg2, T3 arg3);

        public abstract void call<T1, T2, T3, T4>(T1 arg1, T2 arg2, T3 arg3, T4 arg4);

        public abstract void call<T1, T2, T3, T4, T5>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);
    }
}
