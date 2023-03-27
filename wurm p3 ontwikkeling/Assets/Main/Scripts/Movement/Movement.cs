using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
   
    public float hor, ver, speed, normalSpeed, sprint, jumpHight;
    public Vector3 movement, jump;
    public RaycastHit spring;
    public Rigidbody rb;
    public AudioSource lopen, sprinten;
    public bool movementOff;

    private void Start()
    {
        speed = 5;
        normalSpeed = 5;
        sprint = 7;
        movementOff= true;
    }

    // Update is called once per frame
    void Update()
    {
        if (movementOff == true)
        {
          hor = Input.GetAxis("Horizontal");
          ver = Input.GetAxis("Vertical");

          movement.x = hor;
          movement.z = ver;

          transform.Translate(movement * speed * Time.deltaTime);

          if (Input.GetKey(KeyCode.LeftShift))
          {
            speed = sprint;
            
          }
          else
          {
            speed = normalSpeed;
            
          }
       
          if(Physics.Raycast(transform.position, -transform.up, out spring, 2f) && Input.GetKeyDown(KeyCode.Space))
          {       
            rb.AddForce(jump * jumpHight, ForceMode.Impulse);
            
          }

        }
        
    }
}
