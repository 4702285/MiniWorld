using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using System.Diagnostics;
using LuaInterface;

namespace mwt
{
    public partial class Log
    {
        private int mCurLevel = 5;

        [NoToLua]
        public void trace(int lv, string msg, bool writeFile = false, bool writeStack = false)
        {
            if (lv < mCurLevel)
                return;
            if (writeStack)
            {
                msg += "\n" + build_stack();
            }
            if (lv <= 5)
                UnityEngine.Debug.Log(msg);
            else if (lv <= 8)
                UnityEngine.Debug.LogWarning(msg);
            else
                UnityEngine.Debug.LogError(msg);
        }

        private string build_stack()
        {
            StackTrace stack = new StackTrace(3, true);
            StringBuilder builder = new StringBuilder(256);
            for(int level = 0; level < stack.FrameCount; ++ level)
            {
                StackFrame frame = stack.GetFrame(level);
                builder.Append(frame.GetMethod().Name);
                builder.Append(" in ").Append(frame.GetFileName());
                builder.Append("(").Append(frame.GetFileLineNumber()).Append(")").AppendLine();
            }
            return builder.ToString();
        }
    }
}
