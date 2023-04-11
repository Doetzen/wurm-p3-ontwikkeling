using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pijp : MonoBehaviour
{
    public int[] rotations = { 0, 90, 180, 270 };
    private int rando;

    public int[] correctRotation;
    public bool isPlaced = false; 
    int posRotate = 1;
   
    GameManager gameManager;
    public AudioSource plop;

    private void Start()
    {
        gameManager = GameObject.Find("gameKlaar").GetComponent<GameManager>();
        //hij zoekt nu naar mijn emoy gameobject die ik aangemaakt heb. op dit gameobject staat alleen mijn GameManager script.
        //hij zoekt het gameobject en daarna pakt hij het GameManager script zodat die gebruikt kan worden.

        posRotate = rotations.Length;
        
        rando = Random.Range(0, rotations.Length);
        transform.Rotate(0, 0, rotations[rando]);

        if(posRotate > 1)
        {//checken of hij goed staat..... asl hij die goede rotatie heeft die aan is gegeven dan doet hij de check niet en anders doet hij het wel.
         //als hij dan goed staat dan  gebeurt de rest er onder
            if ((int)transform.localEulerAngles.z == correctRotation[0] || (int)transform.localEulerAngles.z == correctRotation[1])
            {//als er 2 mogelijke rotaties zijn dan checkt hij index 0 en index 1
                isPlaced = true;
                gameManager.CorrectMove();
            }
        }
    }
    public void Wurm()  
    {
          
        transform.Rotate(new Vector3(0, 0, 90));
        plop.Play();
        if(posRotate > 1)
        {
            if ((int)transform.localEulerAngles.z == correctRotation[0] || ((int)transform.localEulerAngles.z == correctRotation[1]))
            {
                isPlaced = true;
                gameManager.CorrectMove();
            }
            else
            {
                isPlaced = false;
                
            }
        }
        //Debug.Log(transform.localRotation);
    }
}
