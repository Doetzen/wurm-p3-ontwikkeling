using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RaySign : MonoBehaviour
{
    public RaycastHit hit;
    public TMP_Text signText;
    public Convo signs;



    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit, 2))
        {
            signText.gameObject.SetActive(true);
            signText.text = ("Press E to read");

            if (Input.GetKeyDown(KeyCode.E))
            {

                if (hit.collider.tag == "sign")
                {
                    
                }
            }
        }
        else
        {

            signText.gameObject.SetActive(false);
        }
    }

}
