using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mwt
{
    public abstract class work_item
    {
        public abstract int priority { get; set; }
        public abstract void start();

        public abstract bool is_done();

        public abstract void done();
    }
}
