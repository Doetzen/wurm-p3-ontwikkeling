using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject pijpHouder;
    public GameObject[] pijpjes;

    public  int pijpnummer = 0;
    //om de pijpen bij te houden 
    int goedePijp;
    //hiermee gaan we de pijpen die goed staan bijhouden
   
    void Start()
    {
        pijpnummer = pijpHouder.transform.childCount;
        //pakken het nummer van de totale pijpen door de pijphouder en de childcount
        //returns int value of total pipes
        pijpjes = new GameObject[pijpnummer];
        //we moeten de lengte van de pijpen bepalen dus maken we een nieuwe array aan en stoppen we de pijpnummer er in. dan kunnen we dit gebuiken voor de for loop
        for(int i = 0; i < pijpjes.Length; i++)
        {
            pijpjes[i] = pijpHouder.transform.GetChild(i).gameObject;
            // i for index value
        }//for loop want we moeten door alle pijpjes heen herhalen. bij de for loop vaan we van 0 naar de totale lengte van de array


        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
