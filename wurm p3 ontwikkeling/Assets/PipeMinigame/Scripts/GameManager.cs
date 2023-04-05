using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject pijpHouder;
    public  int pijpNummer = 0;
    //om de pijpen bij te houden 
    int goedePijp = 0;
    //hiermee gaan we de pijpen die goed staan bijhouden
    public MouseLock mouseLock;

    void Start()
    {
        pijpNummer = pijpHouder.transform.childCount;
        //pakken het nummer van de totale pijpen door de pijphouder en de childcount dus als hij start dan telt hij alle pijpen van de child rest pijp. dit zijn er 9
        //en hij wordt laten zien als je op start drukt
        mouseLock.isLocked = false;
    }

    public void CorrectMove()
    {// gaat activeren wanneer we een pijp in de corecte positie draaien
        goedePijp += 1;

        if(goedePijp == pijpNummer)
        {
            print("WHOOOOOOOO");
            SceneManager.LoadScene(1);
        }
    }
}
