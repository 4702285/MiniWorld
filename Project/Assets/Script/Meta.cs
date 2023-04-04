using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meta : MonoBehaviour
{
    private Mesh mMesh = null;

    public void SetColors(Color [] colors)
    {
        List<Vector3> uni_vert = new List<Vector3>();
        Color[] v_colors = new Color[mMesh.vertexCount];
        for(int index = 0; index < mMesh.vertexCount; ++ index)
        {
            int pos = 0;
            for(; pos < uni_vert.Count; ++pos)
            {
                if ((mMesh.vertices[index]-uni_vert[pos]).magnitude <= 0.01)
                    break;
            }
            if ( pos >= uni_vert.Count)
                uni_vert.Add(mMesh.vertices[index]);
            v_colors[index] = pos >= colors.Length ? Color.white : colors[pos];
        }
        mMesh.colors = v_colors;
    }
    // Start is called before the first frame update
    void Start()
    {
        MeshFilter mf = GetComponent<MeshFilter>();
        if (null != mf && null != mf.mesh)
        {
            mMesh = mf.sharedMesh;
        }
    }


    // Update is called once per frame
    void Update()
    {
    }


}
