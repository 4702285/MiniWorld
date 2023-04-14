using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using UnityEngine;

namespace mwt
{
    public class path_util
    {
        public static string trim_sep_end(string uri)
        {            
            int pos = uri.Length - 1;
            while (is_sep(uri[pos])) --pos;
            if (pos < uri.Length - 1)
                return uri.Substring(0, pos);
            return uri;
        }

        public static bool is_sep(char ch)
        {
            //判断字符是否是路径分隔符号
            return ch == Path.DirectorySeparatorChar || ch == Path.AltDirectorySeparatorChar;
        }

        public static string bundle_path(string url)
        {
            return Path.Combine(Application.streamingAssetsPath, url);
        }
    }
}
