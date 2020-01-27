using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pacman_screen_borders : MonoBehaviour
{
    public float x = 13.5f;
    public float y = 7.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -y)
        {
            transform.Translate(Vector3.up * 2*y, Space.World);
        }
        if (transform.position.y > y)
        {
            transform.Translate(Vector3.up * -2*y, Space.World);
        }
        if (transform.position.x > x)
        {
            transform.Translate(Vector3.right * -2*x, Space.World);
        }
        if (transform.position.x < -x)
        {
            transform.Translate(Vector3.right * 2*x, Space.World);
        }
    }
}
