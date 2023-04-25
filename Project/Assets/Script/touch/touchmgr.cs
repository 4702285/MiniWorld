using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using mwt;

public class touchmgr : MonoBehaviour
{
    public const int MOUSE_LBUTTON = 0;
    public const int MOUSE_MBUTTON = 1;
    public const int MOUSE_RBUTTON = 2;

    private Vector3 m_mouse_point_prev = Vector3.zero;

    private scriptobject m_script;

    // Start is called before the first frame update
    void Start()
    {
        m_mouse_point_prev = Input.mousePosition;
        if (m_script == null)
        {
            if (null != main_application.inst.scriptfactory)
                m_script = main_application.inst.scriptfactory.get_object("touchmgr");
        }
    }

    // Update is called once per frame
    void Update()
    {
        on_key_proc();

        if (Input.touchCount <= 0)
        {
            on_mouse_proc();
            return;
        }
        for (int index = 0; index < Input.touches.Length; ++index)
        {
            on_touch(index);
        }
    }

    void on_mouse_proc()
    {
        if (Input.GetMouseButtonDown(MOUSE_LBUTTON))
            on_lbuttondown();
        if (Input.GetMouseButtonDown(MOUSE_MBUTTON))
            on_mbuttondown();
        if (Input.GetMouseButtonDown(MOUSE_RBUTTON))
            on_rbuttondown();
        if (Input.GetMouseButtonUp(MOUSE_LBUTTON))
            on_lbuttonup();
        if (Input.GetMouseButtonUp(MOUSE_MBUTTON))
            on_mbuttonup();
        if (Input.GetMouseButtonUp(MOUSE_RBUTTON))
            on_rbuttonup();
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        if (0 != scroll)
            on_mouse_scroll(scroll);

        if (Input.mousePosition == m_mouse_point_prev)
            return;
        on_mouse_move();
        m_mouse_point_prev = Input.mousePosition;
    }

    void on_lbuttondown()
    {
        if (null != m_script)
        {
            m_script.call<Vector3>("on_lbutton_down", Input.mousePosition);
        }
    }

    void on_mbuttondown()
    {
        if (null != m_script)
        {
            m_script.call<Vector3>("on_mbutton_down", Input.mousePosition);
        }
    }

    void on_rbuttondown()
    {
        if (null != m_script)
        {
            m_script.call<Vector3>("on_rbutton_down", Input.mousePosition);
        }
    }

    void on_lbuttonup()
    {
        if (null != m_script)
        {
            m_script.call<Vector3>("on_lbutton_up", Input.mousePosition);
        }
    }

    void on_mbuttonup()
    {
        if (null != m_script)
        {
            m_script.call<Vector3>("on_mbutton_up", Input.mousePosition);
        }
    }

    void on_rbuttonup()
    {
        if (null != m_script)
        {
            m_script.call<Vector3>("on_rbutton_up", Input.mousePosition);
        }
    }

    void on_mouse_move()
    {
        if (m_script == null)
            return;
        int mask = get_mouse_mask();
        m_script.call<Vector3, Vector3, int>("on_mouse_move", m_mouse_point_prev, Input.mousePosition, mask);
    }

    void on_mouse_scroll(float scroll)
    {
        if (null == m_script)
            return;
        m_script.call<float>("on_mouse_scroll", scroll);
    }

    int get_mouse_mask()
    {
        return (Input.GetMouseButton(MOUSE_LBUTTON)?0:1)|(Input.GetMouseButton(MOUSE_MBUTTON)?0:2)|(Input.GetMouseButton(MOUSE_RBUTTON)?0:4);
    }

    void on_key_proc()
    {
        if (null == m_script)
            return;
        m_script.call("on_key_proc");
    }

    void on_touch(int index)
    {
        if (null == m_script)
            return;
        m_script.call<int>("on_touch", index);
    }
}
