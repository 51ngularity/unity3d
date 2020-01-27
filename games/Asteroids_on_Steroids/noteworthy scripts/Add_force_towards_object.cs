using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Add_force_towards_object : MonoBehaviour
{
    public float force_const = 2;
    public float force_linear = 2;
    public GameObject target;
    public float delay = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (target != null && Time.timeSinceLevelLoad >= delay)
        {

            GetComponent<Rigidbody2D>().AddForce
                (
                (target.transform.position - transform.position).normalized * force_const +
                (target.transform.position - transform.position) * force_linear
                );
        }
    }
}
