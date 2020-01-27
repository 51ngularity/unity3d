using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keep_distance_to_target : MonoBehaviour
{
    public GameObject target;
    public float min_distance = 25;
    public float max_distance = 25;
    //public bool accelerate_towards_min = false;
    public bool accelerate_to_max_else_min = true;
    Vector3 accelerate_towards;
    float current_distance;
    public float force = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (target.gameObject != null)
        {
            if (accelerate_to_max_else_min)
            {
                accelerate_towards = max_distance * (-target.transform.position + transform.position).normalized + target.transform.position;
            }
            else
            {
                accelerate_towards = min_distance * (-target.transform.position + transform.position).normalized + target.transform.position;
            }


            current_distance = (-target.transform.position + transform.position).magnitude;
            if (current_distance < min_distance)
            {
                //add force in direction of safe_position
                GetComponent<Rigidbody2D>().AddForce((-transform.position + accelerate_towards) * force);
            }
            else if (current_distance > max_distance)
            {
                //add force in direction of safe_position
                GetComponent<Rigidbody2D>().AddForce((-transform.position + accelerate_towards) * force);
            }
        }
        
    }
}
