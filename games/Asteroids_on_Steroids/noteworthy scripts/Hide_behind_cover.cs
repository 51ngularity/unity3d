using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hide_behind_cover : MonoBehaviour
{
    public GameObject target;
    public GameObject cover;
    public float distance_to_cover = 10;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = distance_to_cover * (-target.transform.position + cover.transform.position).normalized
            + cover.transform.position;
    }
}
