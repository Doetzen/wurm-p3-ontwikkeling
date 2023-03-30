using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pijp : MonoBehaviour
{
    public float[] rotations = { 0, 90, 180, 270 };
    private int rando;

    public float[] correctRotation;
    //om te checken wanneer de pijpen goed staan
    public bool isPlaced = false;
    //ook om te checken of de pijpen correct staan
    //met deze 2 variables kunnen we kijken of de pijp zijn rotatie de goede is
    int posRotate = 1;
    //deze int gebruiken we om te checken of een pijp meerdere goede rotaties heeft
    public AudioSource plop;

    private void Start()
    {
        posRotate = rotations.Length;
        //hiermee krijgen we de possible rotaties
        rando = Random.Range(0, rotations.Length);
        transform.eulerAngles = new Vector3 (0,0,rotations[rando]);
        if(posRotate > 1)
        {//nu checken we asl de posRotate groter 1 dan 1 dan checken we beide. dus index 0 en index 1
            //als 1 van de 2 goede rotaties gevonden wordt dan gaat isPlaced naar true. isPlaced kijkt of de pijpen goed staan.
            if (transform.eulerAngles.z == correctRotation[0] || transform.eulerAngles.z == correctRotation[1])
            {
                isPlaced = true;
            }
            else
            {//hier staat maar 1 van de 2 want we moeten nogsteeds checken of hij goed staat als hij maar 1 possible rotatie heeft. zoals een hoekpijp
                if (transform.eulerAngles.z == correctRotation[0])
                {
                    isPlaced = true;
                }
            }
        }
       
    }
    public void Wurm()  
    {
          
            transform.Rotate(new Vector3(0, 0, 90));
        plop.Play();
        if(posRotate > 1)
        {
            if (transform.eulerAngles.z == correctRotation[0] || (transform.eulerAngles.z == correctRotation[1] && isPlaced == false))
            {//hier doen we hetzelfde als in de start functie. als er 2 mogelijke rotaties zijn dan checkt hij index 0 en index 1
                isPlaced = true;
            }
            else if (isPlaced == true)
            {
                isPlaced = false;
            }
        }
        else
        {

            if (transform.eulerAngles.z == correctRotation[0] && isPlaced == false)
            {//in de else doen we weer hezelfde. we hoeven maar 1 correcte rotatie te checken
                isPlaced = true;
            }
            else if (isPlaced == true)
            {
                isPlaced = false;
            }
        }
    }
}
