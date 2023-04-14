using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LuaInterface;

namespace mwt
{ 

    class luaobject : scriptobject
    {
        private LuaTable m_obj;
        private Dictionary<string, script_function> m_functions;
        public luaobject(LuaTable t)
        {
            m_obj = t;
        }

        public override script_function get_function(string func_name)
        {
            script_function func;
            if (null != m_functions && m_functions.TryGetValue(func_name, out func))
            {
                return func;
            }
            LuaFunction f = m_obj.GetLuaFunction(func_name);
            if (null == f)
                return null;
            if (null == m_functions)
                m_functions = new Dictionary<string, script_function>();
            func = new luafunction(f);
            m_functions.Add(func_name, func);
            return func;
        }
    }
}
