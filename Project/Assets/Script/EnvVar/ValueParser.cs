using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace EnvVar
{
    /// <summary>
    /// 环境变量解释器，将字符串中的环境变量解析成对应的值，
    /// 运行嵌套，但是不能环形引用
    /// 环境变量格式： ${VarName}
    /// </summary>
    public class ValueParser
    {
        public string GetValue(string exp)
        {
            StringBuilder builder = new StringBuilder();
            int pos = exp.IndexOf('$');
            int prev_pos = 0;
            while (pos >= 0)
            {
                if (exp.Length <= pos + 2)
                    break;
                if (exp[pos + 1] != '{')
                {
                    pos = exp.IndexOf('$', pos + 1);
                    continue;
                }
                int end_pos = exp.IndexOf('}', pos + 1);
                if (end_pos < 0)
                {
                    pos = exp.IndexOf('$', pos + 1);
                    continue;
                }
                builder.Append(exp.Substring(prev_pos, pos - prev_pos));
                builder.Append(GetVariable(exp.Substring(pos + 2, end_pos - pos - 2)));
                prev_pos = end_pos + 1;
                pos = exp.IndexOf('$', prev_pos);
            }
            if (prev_pos == 0)
                return exp;
            builder.Append(exp.Substring(prev_pos));
            return builder.ToString();
        }

        public string GetVariable(string name)
        {
            string val = MainApplication.Inst.GetVariable(name);
            if (string.IsNullOrEmpty(val))
                return "";
            return GetValue(val);
        }
    }
}
