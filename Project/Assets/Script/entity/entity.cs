using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace mwt
{
    public class entity : script_component
    {
        private entityview m_view;

        public entityview view
        {
            get { return m_view; }
            set { m_view = value; }
        }

        public entity(scriptobject obj):base(obj)
        {

        }
        
    }
}
