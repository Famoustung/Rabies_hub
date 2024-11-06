using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    public TextMeshPro scoreTextLevel01;
    public TextMeshPro scoreTextLevel01End;
    public TextMeshPro scoreTextLevel02;
    public TextMeshPro scoreTextLevel02End;
    public TextMeshPro scoreTextLevel03;
    public TextMeshPro scoreTextLevel03End;
    public GameObject gameOver;
    public GameObject LevelSelect;
    public int scoreLevel01;
    public int scoreLevel02;
    public float scoreLevel03;
    private void Awake()
    {
        scoreTextLevel01.text = "คะแนน: " + scoreLevel01;
        if (Instance == null)
        {
            Instance = this;
            /*DontDestroyOnLoad(transform.parent.gameObject);*/
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        // Level01
        scoreTextLevel01.text = "คะแนน: " + scoreLevel01;
        scoreTextLevel01End.text = "คะแนน: " + scoreLevel01;
        if (scoreLevel01 < 0)
        {
            Debug.Log("GameOver");
            scoreLevel01 = 0;
            LevelSelect.SetActive(false);
            gameOver.SetActive(true);
        }
        // Level01
        
        // Level02
        scoreTextLevel02.text = "คะแนน: " + scoreLevel02;
        scoreTextLevel02End.text = "คะแนน: " + scoreLevel02;
        if (scoreLevel02 < 0)
        {
            Debug.Log("GameOver");
            scoreLevel02 = 0;
            LevelSelect.SetActive(false);    
            gameOver.SetActive(true);
        }
        // Level02
        
        // Level03
        int textScoreLevel03 = (int)scoreLevel03;
        scoreTextLevel03.text = "คะแนน: " + textScoreLevel03;
        scoreTextLevel03End.text = "คะแนน: " + scoreLevel03;
        if (scoreLevel03 < 0)
        {
            gameOver.SetActive(true);
        }
        // Level03
    }
    
    // Level01
    public void minusScoreLevel01()
    {
        scoreLevel01--;
    }
    
    public void plusScoreLevel01()
    {
        scoreLevel01++;
    }
    // Level01 
    
    // ----------------------------
    
    // Level02
    public void minusScoreLevel02()
    {
        scoreLevel02--;
    }
    
    public void plusScoreLevel02()
    {
        scoreLevel02++;
    }
    // Level02
    
    // ----------------------------
    
    // Level03
    public void minusScoreLevel03()
    {
        scoreLevel03 -= 0.5f;
    }
    
    public void plusScoreLevel03()
    {
        scoreLevel03 += 1f;
    }
    // Level03
}
