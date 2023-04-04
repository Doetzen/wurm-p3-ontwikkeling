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
   
    public AudioSource plop;

    private void Start()
    {
        posRotate = rotations.Length;
        
        rando = Random.Range(0, rotations.Length);
        transform.Rotate(0, 0, rotations[rando]);
        if(posRotate > 1)
        {
            if ((int)transform.localEulerAngles.z == correctRotation[0] || (int)transform.localEulerAngles.z == correctRotation[1])
            {
                isPlaced = true;
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
            }
            else
            {
                isPlaced = false;
                print(transform.localEulerAngles.z);
            }
        }

        //Debug.Log(transform.localRotation);
       
    }
}
