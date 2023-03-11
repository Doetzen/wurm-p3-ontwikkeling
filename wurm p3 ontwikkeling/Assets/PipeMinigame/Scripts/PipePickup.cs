using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;
using UnityEngine.UIElements;

public class PipePickup : MonoBehaviour
{
    public RaycastHit hittus;
    public GameObject pijp; 

    // Update is called once per frame
    void Update()
    {
        if(Physics.Raycast(transform.position, transform.forward, out hittus, 1000f))
        {
            if(hittus.transform.tag == "pickable")
            {
                if (Input.GetMouseButtonDown(0))
                {
                    
                }
            }
            
        }
    }
}
