using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float hor, ver, speed;
    public Vector3 movement, jump;
    public RaycastHit hit;
    public Rigidbody rb;

    private void Start()
    {
        speed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");

        movement.x = hor;
        movement.z = ver;

        transform.Translate(movement * speed * Time.deltaTime);

        if(Physics.Raycast(transform.position, -transform.up, out hit, 1.5f))
        {
            if (hit.transform.tag == "jumpable")
            {
              
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    rb.velocity += jump;
                }
            }
           
        }

    }
}
