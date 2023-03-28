using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class Movement : MonoBehaviour
{
   
    public float hor, ver, speed, normalSpeed, sprint, jumpHight;
    public Vector3 movement, jump;
    public RaycastHit spring;
    public Rigidbody rb;
    public bool movementOff, move;
    public AudioSource lopen, sproeng;

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

            if (hor != 0 || ver != 0)
            {
                lopen.volume = 1;
            }
            else
            {
                lopen.volume = 0;
            }

          if (Input.GetKey(KeyCode.LeftShift))
          { 
            speed = sprint;
          }
          else
          {
            speed = normalSpeed;
               
          }
       
          if(Physics.Raycast(transform.position, -transform.up, out spring, 1.5f) && Input.GetKeyDown(KeyCode.Space))
          {
                print("fbejskfhrf");
            rb.AddForce(jump * jumpHight, ForceMode.Impulse);
                sproeng.Play();
          }

        }
        //if (hor != 0 || ver != 0)
        //{
        //    move = true;
        //}

        //else
        //{
        //    move = false;
        //}

        //if (move == true)
        //{
        //    lopen.UnPause();
        //}

        //else
        //{
        //    lopen.Pause();
        //}
    }
}
