using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace mwt
{
    class bone
    {
        bone m_parent;
        Vector3 m_scale;
        Vector3 m_position;
        Quaternion m_orient;

        public Vector3 scale{
            get {
                if (m_parent != null)
                    return Vector3.Scale(m_parent.scale, m_scale);
                else
                    return m_scale;
            } 
        }
        public Vector3 position 
        { 
            get 
            {
                if (null != m_parent)
                    return m_parent.position + m_parent.orient * (Vector3.Scale(m_parent.scale, m_position));
                else
                    return m_position;
            } 
        }

        public Quaternion orient
        { 
            get {
                if (m_parent != null)
                    return m_parent.orient * m_orient;
                else
                    return m_orient;
            } 
        }

        Matrix4x4 transform
        {
            get
            {
                return Matrix4x4.TRS(position, orient, scale);
            }
        }
    }

}

