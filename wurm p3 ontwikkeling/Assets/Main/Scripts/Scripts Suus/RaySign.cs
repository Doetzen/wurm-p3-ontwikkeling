using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RaySign : MonoBehaviour
{
    public RaycastHit hit;
    public TMP_Text pressE,signText,closeE;
    public Image theSign;
    public Convo signs;
    public Movement moveOff;
    public FirstPerson noLookie;
    public bool seeTheSing;
    public int randomNumber;


    public void Start()
    {
        pressE.gameObject.SetActive(false);
        signText.gameObject.SetActive(false);
        theSign.gameObject.SetActive(false);
        seeTheSing= false;
        closeE.gameObject.SetActive(false);
        
        

    }

    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit, 2))
        {
            if (hit.collider.tag == "sign")
            {
               pressE.gameObject.SetActive(true);
               pressE.text = ("Press e to read");
              
                if (Input.GetKeyDown(KeyCode.E))
                {
                    randomNumber = Random.Range(1,5);
                    if (seeTheSing == false)
                    {
                        theSign.gameObject.SetActive(true);
                        seeTheSing = true;
                        pressE.fontSize = 0;
                        signText.gameObject.SetActive(true);
                        signText.text = signs.convoText[randomNumber];
                        closeE.gameObject.SetActive(true);
                        closeE.text = ("press e to close");


                    }
                    else if (seeTheSing == true)
                    { 
                        theSign.gameObject.SetActive(false);
                        seeTheSing = false;
                        pressE.fontSize = 99;
                        signText.gameObject.SetActive(false);
                        closeE.gameObject.SetActive(false);

                    }

                    

                }
               


            }
            

         
        }
        else
        {
                pressE.gameObject.SetActive(false);
             
        }

        if (seeTheSing == true)
        {
            moveOff.movementOff = false;
            noLookie.cameraOff= false;
        }
        else
        {
            moveOff.movementOff = true;
            noLookie.cameraOff = true;
        }
      
    }

}
