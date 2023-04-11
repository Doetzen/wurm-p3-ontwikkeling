using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RaySign : MonoBehaviour
{
    public RaycastHit hit;
    public TMP_Text pressE,signText;
    public Image theSign;
    public Convo signs;
    public bool seeTheSing;


    public void Start()
    {
        pressE.gameObject.SetActive(false);
        signText.gameObject.SetActive(false);
        theSign.gameObject.SetActive(false);
        seeTheSing= false;

    }

    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit, 2))
        {
            if (hit.collider.tag == "sign")
            {
               pressE.gameObject.SetActive(true);
               pressE.text = ("Press E to read");  
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (seeTheSing == false)
                    {
                        theSign.gameObject.SetActive(true);
                        seeTheSing = true;




                    }
                    else if (seeTheSing == true)
                    { 
                        theSign.gameObject.SetActive(false);
                        seeTheSing = false;
        
                    }

                    

                }


            }

         
        }
        else
        {

            pressE.gameObject.SetActive(false);
        }
    }

}
