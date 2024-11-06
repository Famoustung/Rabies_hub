using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level2 : MonoBehaviour
{
    
    
    public GameObject nextBtn;
    

    [Header("Score")] 
    public TextMeshProUGUI scoreText;
    public int score;
    
    public int ScoreWin;
    public TextMeshProUGUI scoreTextWin;

    [Header("Time")]
    public float timeRemaining = 1;
    public bool timerIsRunning = true;
    public TextMeshProUGUI timeText;
    
    
    [Header("Amount")] 
    public TextMeshProUGUI amount;
    
    
    [Header("Picture")] 
    public GameObject[] image;
    public int i;
    
    
    [Header("PowerBar")]  
    public Slider imagePower;
    public float amtPower;
    public float powerSpeed = 1f;
    public bool Isfull = false;
    public GameObject arrowHead1, arrowHead2;

    [Header("Button")] 
    public Button stopBtn;
    public bool IsPress;

    [Header("Indicator")]
    public GameObject ScoreText;
    public GameObject MinusScoreText;


    public GameObject Win;
    public GameObject GameOver;

    public GameObject HowToPlay;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        //timerIsRunning = true;
        amtPower = 0f;
        Win.SetActive(false);
        GameOver.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (HowToPlay.activeInHierarchy)
                {
                    timerIsRunning = false;
                }
                else
                {
                    timerIsRunning = true;
                }
        
                if (timerIsRunning)
                {
                    SliderPlay();
                }



        imagePower.value = amtPower;

        scoreText.text = "คะแนน : " +score;
        amount.text = i+"/4";
        
        ScoreWin = score;
        
        scoreTextWin.text = "คะแนน : "+ScoreWin;
        switch (i)
        {
            case 0: 
                image[0].SetActive(true);
                image[1].SetActive(false);
                image[2].SetActive(false);
                image[3].SetActive(false);
                break;
            case 1: 
                image[1].SetActive(true);
                image[2].SetActive(false);
                image[3].SetActive(false);
                image[0].SetActive(false);
                break;
            case 2: 
                image[2].SetActive(true);
                image[3].SetActive(false);
                image[1].SetActive(false);
                image[0].SetActive(false);
                break;
            case 3: 
                image[3].SetActive(true);
                image[0].SetActive(false);
                image[1].SetActive(false);
                image[2].SetActive(false);
                break;
        }

        if (i>4)
        {
            
            i = 4;
        }
        else if (i == 4)
        {
            timerIsRunning = false;
            nextBtn.SetActive(true);
            stopBtn.interactable = false;
            if (!Win.gameObject.activeInHierarchy)
            {
                SoundManager.Instance.PlaySound(SoundType.victory, false);
            }
                Win.SetActive(true);
            
        }

        if (score < 0)
        {
            timeRemaining = 0;
            timerIsRunning = false;
            stopBtn.interactable = false;
            if (!GameOver.gameObject.activeInHierarchy)
            {
                SoundManager.Instance.PlaySound(SoundType.game_over, false);
            }
                GameOver.SetActive(true);
            
        }
        
        if (timerIsRunning)
        {
            SliderPlay();
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;
                stopBtn.interactable = false;
                
                GameOver.SetActive(true);
                SoundManager.Instance.PlaySound(SoundType.game_over, false);
            }
        }
    }
    
    public void BottonDwn()
    {
        IsPress = true;
        SoundManager.Instance.PlaySound(SoundType.bubble_pop,false);
        if (IsPress)
        {
            
            if (amtPower >= 0f && amtPower < 0.3f)
            {
                Score indicator = Instantiate(MinusScoreText, transform.position, Quaternion.identity).GetComponent<Score>();
                score -= 10;
                Debug.Log("fail");
                SoundManager.Instance.PlaySound(SoundType.fail, false);
                StartCoroutine(Example());
                amtPower = 0;
                IsPress = false;  
            }
            
            if (amtPower >= 0.31f && amtPower < 0.6f)
            {
                Score indicator = Instantiate(ScoreText, transform.position, Quaternion.identity).GetComponent<Score>(); 
                score += 10; 
                i++;
                Debug.Log("pass");
                SoundManager.Instance.PlaySound(SoundType.correct, false);
                StartCoroutine(Example());
                amtPower = 0;
                IsPress = false;  
            }

            if (amtPower > 0.61f && amtPower <= 0.99f)
            {
                Score indicator = Instantiate(MinusScoreText, transform.position, Quaternion.identity).GetComponent<Score>();
                score -= 10;
                SoundManager.Instance.PlaySound(SoundType.fail, false);
                Debug.Log("fail"); 
                StartCoroutine(Example());
                amtPower = 0;
                    IsPress = false; 
            } 
        }
    }
    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60); 
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("Time : "+"{0:00}:{1:00}", minutes, seconds);
    }

    void SliderPlay()
    {
        if (!Isfull)
        {
            amtPower += Time.deltaTime * (powerSpeed/2);
            arrowHead1.SetActive(true);
            if (amtPower >= 1f)
            {
                Isfull = true;
                arrowHead1.SetActive(false);
                
            } 
        }
        else if (Isfull)
        {
            amtPower -= Time.deltaTime * (powerSpeed/2);
            arrowHead2.SetActive(true);
            if (amtPower <= 0.0f )
            {
                Isfull = false;
                arrowHead2.SetActive(false);        
            }
        } 
    }
    
   

IEnumerator Example()
{
    timerIsRunning = false;
    yield return new WaitForSeconds(5);
    timerIsRunning = true;
}

    public void Restart()
    {
        SceneManager.LoadScene("Level1");
    }

    public void Pass()
    {
        SceneManager.LoadScene("Level2");
    }
}

