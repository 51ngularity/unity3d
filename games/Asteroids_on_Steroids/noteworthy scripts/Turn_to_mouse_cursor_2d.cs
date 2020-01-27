using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn_to_mouse_cursor_2d : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    Vector3 m_MousePosition_2D()
    {
        Vector3 vec = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        vec.z = transform.position.z;
        return vec;
    }

    void Update()
    {
        transform.up = (m_MousePosition_2D() - transform.position).normalized;
    }
}
