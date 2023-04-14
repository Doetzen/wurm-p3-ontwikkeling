using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject pijpHouder;
    public GameObject backKnop;
    public  int pijpNummer = 0; 
    public Pijp[] pijp;
  
    void Start()
    {
        pijpNummer = pijpHouder.transform.childCount;
    }

    public void Update()
    {
        if (pijp[0].isPlaced == true && pijp[1].isPlaced == true && pijp[2].isPlaced == true && pijp[3].isPlaced == true && pijp[4].isPlaced == true && pijp[5].isPlaced == true && pijp[6].isPlaced == true && pijp[7].isPlaced == true && pijp[8].isPlaced == true)
        {
            backKnop.SetActive(true);
        }
    }

  
}
