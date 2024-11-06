using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ManagerScoreStage04 : MonoBehaviour
{
    public int score;
    public GameObject gameOver;
    public GameObject gameOverLevelSelect;
    public TextMeshPro scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "คะแนน: " + score;

        if (score < 0)
        {
            gameOver.SetActive(true);
            gameOverLevelSelect.SetActive(false);
        }
    }

    public void Worng()
    {
        Debug.Log("Score = -1");
        score--;
        return;
    }
    
    public void Corrent()
    {
        Debug.Log("Score = +1");
        score++;
        return;
    }
}
