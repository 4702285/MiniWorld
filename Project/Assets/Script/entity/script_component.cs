using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace mwt
{
    public class script_component : MonoBehaviour
    {
        // Start is called before the first frame update
        protected void Start()
        {
            Log.log("create object {0}", GetType().Name);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}
