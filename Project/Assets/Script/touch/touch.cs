using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace mwt
{
    public static class touch
    {
        public static int finger(int idx)
        {
            return Input.GetTouch(idx).fingerId;
        }

        public static Vector2 position(int idx)
        {
            return Input.GetTouch(idx).position;
        }

        public static Vector2 raw_pos(int idx)
        {
            return Input.GetTouch(idx).rawPosition;
        }

        public static Vector2 delta_pos(int idx)
        {
            return Input.GetTouch(idx).deltaPosition;
        }

        public static float delta_time(int idx)
        {
            return Input.GetTouch(idx).deltaTime;
        }

        public static int tap(int idx)
        {
            return Input.GetTouch(idx).tapCount;
        }

        public static int phase(int idx)
        {
            return (int)Input.GetTouch(idx).phase;
        }
    }
}
