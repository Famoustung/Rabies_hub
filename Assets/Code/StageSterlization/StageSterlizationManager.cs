using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageSterlizationManager : MonoBehaviour
{
    public GameObject[] Level;
    
    
    
    private void Start()
    {
       
        
    }

    public void ToLevelSelect()
    {
        Level[1].SetActive(true);
        Level[0].SetActive(false);
    }

    public void SelectToLevel1()
    {
        Level[2].SetActive(true);
        Level[1].SetActive(false); 
    }

    public void SelectToLevel2()
    {
        Level[3].SetActive(true);
        Level[1].SetActive(false);
    }
    
    public void Level1ToLevel2()
    {
        Level[3].SetActive(true);
        Level[2].SetActive(false);
    }

    public void Level2ToLevel1()
    {
        Level[2].SetActive(true);
        Level[3].SetActive(false);
    }
    private void GameOver()
    {
        
    }

    private void End()
    {
        
    }
}
