using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;
using UnityEngine.UIElements;

public class PipePickup : MonoBehaviour
{
    public RaycastHit hit;
    public GameObject pijp;

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (pijp == null)
            {
                RaycastHit hit = CastRay();
                if (hit.collider != null)
                {
                    //checken of de raycast een collider hit 
                    if (!hit.collider.CompareTag("drag"))
                    {
                        print("fwruihfiu");
                        return;
                    }//met de return gaat hij uit de functie voor als hij geen collider raakt
                    pijp = hit.collider.gameObject;
                    //dit hele stuk hierboven is om een object op te pakken
                }
            }
            else
            {

                // als een pijp niet geselecteerd/ opgepakt is dan willen we het neerzetten
            }
        }
        if (pijp != null)
        {
            Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.WorldToScreenPoint(pijp.transform.position).z);

        }
    }
    private RaycastHit CastRay()
    {
        //info zodat hij moet weten dat hij kan draggen en droppen
        
            Vector3 screenMousePosFar = new Vector3(
                Input.mousePosition.x,
                Input.mousePosition.y,
                Camera.main.farClipPlane);
            Vector3 screenMousePosNear = new Vector3(
                Input.mousePosition.x,
                Input.mousePosition.y,
                Camera.main.nearClipPlane);

            Vector3 worldMousePosFar = Camera.main.ScreenToWorldPoint(screenMousePosFar);
            Vector3 worldMousePostNear = Camera.main.ScreenToWorldPoint(screenMousePosNear);
            Physics.Raycast(worldMousePostNear, worldMousePosFar - worldMousePostNear, out hit);
                //eerste is origin en die twwede is de distance tussen de worlMousePosNear en de worldMousePosfar

                return hit;
        
    }
}
