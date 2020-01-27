using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ad_force_orthogonal_to_target : MonoBehaviour
{
    public float force = 2;
    public GameObject target;
    Vector2 vec = new Vector2(0,0);
    public bool reverse_direction = false;
    private int reverse = 1;
    // Start is called before the first frame update
    void Start()
    {
        if (reverse_direction)
        {
            reverse = -1;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        vec.x = -(target.transform.position - transform.position).y;
        vec.y = (target.transform.position - transform.position).x;
        GetComponent<Rigidbody2D>().AddForce(vec * reverse * force);
    }
}
