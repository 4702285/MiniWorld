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
        private List<xbone> m_childs;
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

        public Vector3 position
        {
            get
            {
                if (m_need_update)
                    update();
                return m_position;
            }
        }

        public Quaternion orient
        {
            get
            {
                if (m_need_update)
                    update();
                return m_orient;
            }
        }

        private void update()
        {
            if (null != m_parent)
            {
                m_scale = Vector3.Scale(m_parent.scale, m_local_scale);
                m_position = m_parent.position + m_parent.orient * (Vector3.Scale(m_parent.scale, m_local_position));
                m_orient = m_parent.orient * m_local_orient;
            }
            else
            {
                m_scale = m_local_scale;
                m_position = m_local_position;
                m_orient = m_local_orient;
            }
        }

        public void set_needupdate()
        {
            m_need_update = true;
            if (null == m_childs || m_childs.Count == 0)
                return;
            for(int index = 0; index < m_childs.Count; ++index)
            {
                m_childs[index].set_needupdate();
            }
        }
    }
}
