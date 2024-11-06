using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerStage01 : MonoBehaviour
{
    // Score
    public int score = 0;
    public TextMeshPro scoreText;
    public TextMeshProUGUI WinScoreText ;
    // Timer
    public float timer;
    public TextMeshPro timerText;
    

    [Header("DoneAnimal")] 
    public Button[] AnimalWanted;
    public int AnimalNumber;
    
    [Header("Indicator")]
    public GameObject ScoreText;
    public GameObject MinusScoreText;
    public GameObject DuplicateScore;
    

    private Spawner Spawner;
    private bool StartGame;
    public GameObject HOWTOPLAY;
    public GameObject Win;
    public GameObject End;
    
    void Start()
    {
        scoreText.text = "คะแนน: " + score;
        End.SetActive(false);
        Win.SetActive(false);
        StartGame = false;
       // HOWTOPLAY.SetActive(true);
    }

    void Update()
    {
        WinScoreText.text = scoreText.text;

        if (!HOWTOPLAY.activeInHierarchy)
        {
            StartGame = true;
        }
        if (StartGame)
        {
            timer = timer - Time.deltaTime;

            timerText.text = "เวลา: " + (timer.ToString("0"));


            LockAnimal();

            if (timer <= 0)
            {
                Spawner = GameObject.Find("Spawner").GetComponent<Spawner>();
                Spawner.start = false;
                Win.SetActive(true);
                timer = 0;
            }

          /*  if (AnimalWanted[0].interactable == false &&
                AnimalWanted[1].interactable == false &&
                AnimalWanted[2].interactable == false &&
                AnimalWanted[3].interactable == false &&
                AnimalWanted[4].interactable == false
            )
            {
                timer = 0;

                if (!Win.gameObject.activeInHierarchy)
                {
                    SoundManager.Instance.PlaySound(SoundType.victory, false);
                }

                Win.gameObject.SetActive(true);
                
            }*/

            if (score < 0)
            {
                timer = 0;
                Win.gameObject.SetActive(false);
                if (!End.gameObject.activeInHierarchy)
                {
                    SoundManager.Instance.PlaySound(SoundType.game_over, false);
                }
                End.gameObject.SetActive(true);
            }
        }
    }

    public void AddScore(int value)
    {
        
        score += value;
        scoreText.text = "คะแนน: " + score;
        
        
        
        if (timer <= 0)
        {
            Win.SetActive(false);
            StartGame = false;
        }
    }

    public void LockAnimal()
    {
        switch (AnimalNumber)
        {
            case 0 :
                break; 
            case 1 :
                if (AnimalWanted[0].interactable == false)
                {
                    /* Debug.Log("ซ้ำ");
                     SoundManager.Instance.PlaySound(SoundType.wrong, false);
                     Score indicator2 = Instantiate(DuplicateScore, transform.position, Quaternion.identity).GetComponent<Score>();*/
                    AddScore(10);
                    SoundManager.Instance.PlaySound(SoundType.correct, false);
                    Score indicator1 = Instantiate(ScoreText, transform.position, Quaternion.identity).GetComponent<Score>();
                }
                else
                {
                    AnimalWanted[0].interactable = false;
                    AddScore(10);
                    SoundManager.Instance.PlaySound(SoundType.correct, false);
                    Score indicator1 = Instantiate(ScoreText, transform.position, Quaternion.identity).GetComponent<Score>();
                }
                
                
                break;
            case 2 :
                if (AnimalWanted[1].interactable == false)
                {
                    /* Debug.Log("ซ้ำ");
                     SoundManager.Instance.PlaySound(SoundType.wrong, false);
                     Score indicator2 = Instantiate(DuplicateScore, transform.position, Quaternion.identity).GetComponent<Score>();*/
                    AddScore(10);
                    SoundManager.Instance.PlaySound(SoundType.correct, false);
                    Score indicator1 = Instantiate(ScoreText, transform.position, Quaternion.identity).GetComponent<Score>();
                }
                else
                {
                    AnimalWanted[1].interactable = false; 
                    AddScore(10);
                    SoundManager.Instance.PlaySound(SoundType.correct, false);
                    Score indicator1 = Instantiate(ScoreText, transform.position, Quaternion.identity).GetComponent<Score>(); 
                }
                
                
                break;
            case 3 :
                if (AnimalWanted[2].interactable == false)
                {
                    /*  Debug.Log("ซ้ำ");
                      SoundManager.Instance.PlaySound(SoundType.wrong, false);
                      Score indicator2 = Instantiate(DuplicateScore, transform.position, Quaternion.identity).GetComponent<Score>(); */
                    AddScore(10);
                    SoundManager.Instance.PlaySound(SoundType.correct, false);
                    Score indicator1 = Instantiate(ScoreText, transform.position, Quaternion.identity).GetComponent<Score>();
                }
                else
                {
                    AnimalWanted[2].interactable = false; 
                    AddScore(10);
                    SoundManager.Instance.PlaySound(SoundType.correct, false);
                    Score indicator1 = Instantiate(ScoreText, transform.position, Quaternion.identity).GetComponent<Score>();
                }
                
                break;
            case 4 :
                if (AnimalWanted[3].interactable == false)
                {
                    /* Debug.Log("ซ้ำ");
                     SoundManager.Instance.PlaySound(SoundType.wrong, false);
                     Score indicator2 = Instantiate(DuplicateScore, transform.position, Quaternion.identity).GetComponent<Score>();*/
                    AddScore(10);
                    SoundManager.Instance.PlaySound(SoundType.correct, false);
                    Score indicator1 = Instantiate(ScoreText, transform.position, Quaternion.identity).GetComponent<Score>();
                }
                else
                {
                    AnimalWanted[3].interactable = false; 
                    AddScore(10);
                    SoundManager.Instance.PlaySound(SoundType.correct, false);
                    Score indicator1 = Instantiate(ScoreText, transform.position, Quaternion.identity).GetComponent<Score>();
                }
                
                
                break;
            case 5 :
                if (AnimalWanted[4].interactable == false)
                {
                    /* Debug.Log("ซ้ำ");
                     SoundManager.Instance.PlaySound(SoundType.wrong, false);
                     Score indicator2 = Instantiate(DuplicateScore, transform.position, Quaternion.identity).GetComponent<Score>();*/
                    AddScore(10);
                    SoundManager.Instance.PlaySound(SoundType.correct, false);
                    Score indicator1 = Instantiate(ScoreText, transform.position, Quaternion.identity).GetComponent<Score>();
                }
                else
                {
                    AnimalWanted[4].interactable = false; 
                    AddScore(10);
                    SoundManager.Instance.PlaySound(SoundType.correct, false);
                    Score indicator1 = Instantiate(ScoreText, transform.position, Quaternion.identity).GetComponent<Score>();
                }
                break;
            default: AddScore(-10);
                SoundManager.Instance.PlaySound(SoundType.wrong, false);
                Score indicator = Instantiate(MinusScoreText, transform.position, Quaternion.identity).GetComponent<Score>(); 
                Debug.Log("ลบคะแนน");
                break;
        }

        
        
        
        
        
        
    }
    
}
