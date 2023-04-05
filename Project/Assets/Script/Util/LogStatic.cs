using System;
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
            main_application.inst.Log.trace(VERBOSE, format(VERBOSE, fmt, args));
        }

        public static void debug(string fmt, params object [] args)
        {
            main_application.inst.Log.trace(DEBUG, format(DEBUG, fmt, args));
        }

        public static void detail(string fmt, params object [] args)
        {
            main_application.inst.Log.trace(DETAIL, format(DETAIL, fmt, args));
        }

        public static void info(string fmt, params object [] args)
        {
            main_application.inst.Log.trace(INFO, format(DETAIL, fmt, args));
        }

        public static void log(string fmt, params object[] args)
        {
            main_application.inst.Log.trace(LOG, format(LOG, fmt, args));
        }

        public static void notice(string fmt, params object [] args)
        {
            main_application.inst.Log.trace(NOTICE, format(NOTICE, fmt, args));
        }

        public static void emphase(string fmt, params object [] args)
        {
            main_application.inst.Log.trace(EMPHASE, format(EMPHASE, fmt, args));
        }

        public static void warning(string fmt, params object [] args)
        {
            main_application.inst.Log.trace(WARNING, format(WARNING, fmt, args));
        }

        public static void fault(string fmt, params object [] args)
        {
            main_application.inst.Log.trace(FAULT, format(FAULT, fmt, args));
        }

        public static void error(string fmt, params object [] args)
        {
            main_application.inst.Log.trace(ERROR, format(ERROR, fmt, args));
        }

        public static void exception(Exception ex)
        {
            main_application.inst.Log.trace(ERROR, ex.Message+"\n"+ex.Source+"\n"+ex.StackTrace, false, false);
            
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
