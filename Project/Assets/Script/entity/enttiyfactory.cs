using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mwt
{
    public class enttiyfactory
    {
        public entity create(scriptobject obj, scriptobject view, scriptobject context)
        {
            entity e = new entity(obj);
            entityview v = new entityview(view);
            v.attach(e);
            v.create(context);
            return e;
        }
    }
}
