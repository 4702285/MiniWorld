﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LuaInterface;

namespace mwt
{
    public partial class Log
    {
        public const int ERROR = 10;
        public const int FAULT = 9;
        public const int WARNING = 8;
        public const int EMPHASE = 7;
        public const int NOTICE = 6;
        public const int LOG = 5;
        public const int INFO = 4;
        public const int DETAIL = 3;
        public const int DEBUG = 2;
        public const int VERBOSE = 1;

        public static void verbose(string fmt, params object [] args)
        {
            MainApplication.Inst.Log.trace(VERBOSE, format(VERBOSE, fmt, args));
        }

        public static void debug(string fmt, params object [] args)
        {
            MainApplication.Inst.Log.trace(DEBUG, format(DEBUG, fmt, args));
        }

        public static void detail(string fmt, params object [] args)
        {
            MainApplication.Inst.Log.trace(DETAIL, format(DETAIL, fmt, args));
        }

        public static void info(string fmt, params object [] args)
        {
            MainApplication.Inst.Log.trace(INFO, format(DETAIL, fmt, args));
        }

        public static void log(string fmt, params object[] args)
        {
            MainApplication.Inst.Log.trace(LOG, format(LOG, fmt, args));
        }

        public static void notice(string fmt, params object [] args)
        {
            MainApplication.Inst.Log.trace(NOTICE, format(NOTICE, fmt, args));
        }

        public static void emphase(string fmt, params object [] args)
        {
            MainApplication.Inst.Log.trace(EMPHASE, format(EMPHASE, fmt, args));
        }

        public static void warning(string fmt, params object [] args)
        {
            MainApplication.Inst.Log.trace(WARNING, format(WARNING, fmt, args));
        }

        public static void fault(string fmt, params object [] args)
        {
            MainApplication.Inst.Log.trace(FAULT, format(FAULT, fmt, args));
        }

        public static void error(string fmt, params object [] args)
        {
            MainApplication.Inst.Log.trace(ERROR, format(ERROR, fmt, args));
        }

        [NoToLua]
        public static string format(int lv, string fmt, params object [] args)
        {
            if (null == args)
                return fmt;
            return string.Format(fmt, args);
        }
    }
}
