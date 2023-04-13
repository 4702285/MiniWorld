using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace mwt
{
    class xbone
    {
        private xbone m_parent;
        private Vector3 m_scale;
        private Vector3 m_local_scale;
        private Vector3 m_position;
        private Vector3 m_local_position;
        private Quaternion m_orient;
        private Quaternion m_local_orient;
        private bool m_need_update = true;

        public Vector3 scale
        {
            get { 
                if (m_need_update)
                {
                    update();
                }
                return m_scale;
            }
        }

        private void update()
        {
            if (null != m_parent)
                m_scale = Vector3.Scale(m_parent.scale, m_local_scale);
            else
                m_scale = m_local_scale;

        }
    }
}
