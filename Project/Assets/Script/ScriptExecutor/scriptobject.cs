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
    }
}
