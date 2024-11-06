using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class PostTest : MonoBehaviour
{
    private float score;
    private int count;

    private void Start()
    {
        count = PlayerPrefs.GetInt("AmountPostTest", 0);
    }

    public void End()
    {
        Time.timeScale = 1;
        score = GameObject.Find("GameManagerQuestions").GetComponent<QuestionManagerFix>().score;
      
        PlayerPrefs.SetFloat("ScorePostTest",score);

        count++;
        
        PlayerPrefs.SetInt("AmountPostTest", count);
        Application.ExternalCall("onGameCompleted");
      //  SceneManager.LoadScene("Credit");
        SceneManager.LoadScene("StageSelections");
    }

    public void Menu()
    {
        Time.timeScale = 1;
        score = GameObject.Find("GameManagerQuestions").GetComponent<QuestionManagerFix>().score;
      
        PlayerPrefs.SetFloat("ScorePostTest",score);
        SceneManager.LoadScene("StageSelections");  
    }

    public void Restart()
    {
        Time.timeScale = 1;
        score = GameObject.Find("GameManagerQuestions").GetComponent<QuestionManagerFix>().score;
      
        PlayerPrefs.SetFloat("ScorePostTest",score);

        count++;
        
        PlayerPrefs.SetInt("AmountPostTest", count);
        SceneManager.LoadScene("Post-tests");  
    }
}
