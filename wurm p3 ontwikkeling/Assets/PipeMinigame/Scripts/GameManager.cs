using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject pijpHouder;
    public GameObject backKnop;
    public  int pijpNummer = 0; 
    int goedePijp = 0;
    //hiermee gaan we de pijpen die goed staan bijhouden
   
    
 

    void Start()
    {
        pijpNummer = pijpHouder.transform.childCount;
        
      
    }

    public void CorrectMove()
    {
        goedePijp += 1;

        if(goedePijp == pijpNummer)
        {
           
            backKnop.SetActive(true);
            
            
        }
    }
}
