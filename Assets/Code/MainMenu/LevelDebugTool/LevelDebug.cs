using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;


public class LevelDebug : MonoBehaviour
{
    
    public GameObject thisScene;
    public GameObject debug;
    public bool a = false;
    public void Update()
    {
       
    }

    public void Open()
    {
        if (!a)
        {
            debug.SetActive(true);
            a = true;
        }
        else
        {
            debug.SetActive(false);
            a = false;
        }
        
    }

   

    

    public void LevelUp()
    {
        PlayerPrefs.SetInt("levelAt", PlayerPrefs.GetInt("levelAt") + 1 );
        Debug.Log(PlayerPrefs.GetInt("levelAt"));
    }

    public void LevelDown()
    {
        PlayerPrefs.SetInt("levelAt", PlayerPrefs.GetInt("levelAt") - 1 );
        Debug.Log(PlayerPrefs.GetInt("levelAt"));
    }

    public void ResetLevel()
    {
        PlayerPrefs.SetInt("levelAt", 0 );
        Debug.Log(PlayerPrefs.GetInt("levelAt"));
    }

    public void ShowData()
    {
        Debug.Log(PlayerPrefs.GetInt("levelAt"));
        Debug.Log(PlayerPrefs.GetFloat("ScorePreTest"));
        Debug.Log(PlayerPrefs.GetFloat("SccoreStage1"));
        Debug.Log(PlayerPrefs.GetFloat("ScoreStage2"));
        Debug.Log(PlayerPrefs.GetFloat("ScoreStage3"));
        Debug.Log(PlayerPrefs.GetFloat("ScoreStage4"));
        Debug.Log(PlayerPrefs.GetFloat("ScoreStage5"));
        Debug.Log(PlayerPrefs.GetFloat("ScoreStage6"));
        Debug.Log(PlayerPrefs.GetFloat("ScorePostTest"));
        
    }

    
}
