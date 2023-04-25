using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace mwt
{
    public class entityview : MonoBehaviour
    {
        scriptobject m_script;
        entity m_entity;
        GameObject m_go;
        public entityview (scriptobject obj)
        {
            m_script = obj;
        }

        public void attach(entity e)
        {
            m_entity = e;
            e.view = this;
        }

        public bool create(scriptobject context)
        {
            script_function func = m_script.get_function("create");
            if (null != func)
                return func.invoke<bool, scriptobject>(context);
            string asset = context.get_value<string>("asset");
            if (string.IsNullOrEmpty(asset))
                return false;
            return main_application.inst.resource.load_asset(asset, resourceloader.PRIO_ENTITY, typeof(GameObject), on_entity_loaded, this);
        }

        private void on_entity_loaded(string path, object obj, object param)
        {
            if (null == obj)
                return;
            GameObject go = obj as GameObject;
            m_go = Instantiate(go);
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}
