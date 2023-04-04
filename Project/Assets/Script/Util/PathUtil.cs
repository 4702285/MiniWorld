using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace mwt
{
    public class PathUtil
    {
        public static string TrimSepEnd(string uri)
        {            
            int pos = uri.Length - 1;
            while (IsSep(uri[pos])) --pos;
            if (pos < uri.Length - 1)
                return uri.Substring(0, pos);
            return uri;
        }

        public static bool IsSep(char ch)
        {
            //判断字符是否是路径分隔符号
            return ch == Path.DirectorySeparatorChar || ch == Path.AltDirectorySeparatorChar;
        }
    }
}
