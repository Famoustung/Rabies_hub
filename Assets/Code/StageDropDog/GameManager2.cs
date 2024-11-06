using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager2 : MonoBehaviour
{
   
    public bool StartGame = false;
    // Score
    public int score = 0;
    public TextMeshPro scoreText;

    public TextMeshProUGUI WinScoreText;
    // Timer
    public float timer;
    public TextMeshPro timerText;
    
    public Animator cardShuffle;
    public GameObject[] Cards;
    public float CardNumber;


    
    public TextMeshProUGUI AmoutText1, AmoutText2,AmoutText3,AmoutText4, AmoutText5,AmoutText6;
    private int Amount1, Amount2, Amount3, Amount4, Amount5, Amount6;

    public GameObject Win;
    public GameObject End ;

    public GameObject HOWTOPLAY;

    
   private void Start()
   {
       StartGame = false;
       scoreText.text = "คะแนน: " + score;
      RandomCard();
      
      End.SetActive(false);

        Amount1 = 2;
        Amount2 = 3;
        Amount3 = 2;
        Amount4 = 3;
        Amount5 = 3;
        Amount6 = 2;

    }

   private void Update()
   {
       if (!HOWTOPLAY.activeInHierarchy)
       {
           StartGame = true;
       }
       
       if (StartGame)
       {
           timer =timer - Time.deltaTime;
        
           timerText.text = "เวลา: " + (timer.ToString("0"));

           if (timer <= 0)
           {
               Win.SetActive(true);
               timer = 0;
           }

           if (score < 0)
           {
               End.SetActive(true);
           }

          
       }

        AmoutText1.text = ""+Amount1;
        AmoutText2.text = "" + Amount2;
        AmoutText3.text = "" + Amount3;
        AmoutText4.text = "" + Amount4;
        AmoutText5.text = "" + Amount5;
        AmoutText6.text = "" + Amount6;
    }


   public void minus1()
    {
        Amount1--;
    }
    public void minus2() 
    {
        Amount2--;
    }
    public void minus3() 
    { 
        Amount3--;
    }
    public void minus4() 
    { 
        Amount4--;
    }
    public void minus5() 
    {
        Amount5--;
    }
    public void minus6() 
    {
        Amount6--;
    }


   public void AddScore(int value)
   {
       score += value;
       scoreText.text = "คะแนน: " + score; 
       WinScoreText.text = scoreText.text;
       
   }
   
   private void ShuffleCard()
   {
       // SoundManager.Instance.PlaySound(SoundType.shuffle_card, false);
        cardShuffle.SetTrigger("Play");
        cardShuffle.SetTrigger("Idle");
   }

   IEnumerator nextCard(float delayTime)
   {
       Cards[0].SetActive(false);
       Cards[1].SetActive(false);
       Cards[2].SetActive(false);
       Cards[3].SetActive(false);
       Cards[4].SetActive(false);
       Cards[5].SetActive(false);
       Cards[6].SetActive(false);
       Cards[7].SetActive(false);
       Cards[8].SetActive(false);
       Cards[9].SetActive(false); 
       Cards[10].SetActive(false);
       Cards[11].SetActive(false);
       Cards[12].SetActive(false);
       Cards[13].SetActive(false);
       Cards[14].SetActive(false);
       yield return new WaitForSeconds(delayTime);
       
       CardShowing();
       CardNumber++;  
       
   }

   public void RandomCard()
   {
       
        ShuffleCard();
        StartCoroutine(nextCard(2.2f));
       
   }

   public void CardShowing()
   {
       
       switch (CardNumber)
       {
           case 0 : 
               Cards[0].SetActive(true);
               break;
           case 1 : 
               Cards[1].SetActive(true); 
               break;
           case 2 : 
               Cards[2].SetActive(true); 
               break;
           case 3 : 
               Cards[3].SetActive(true); 
               break;
           case 4 : 
               Cards[4].SetActive(true); 
               break;
           case 5 : 
               Cards[5].SetActive(true); 
               break;
           case 6 : 
               Cards[6].SetActive(true); 
               break;
           case 7 : 
               Cards[7].SetActive(true); 
               break;
           case 8 : 
               Cards[8].SetActive(true); 
               break;
           case 9 : 
               Cards[9].SetActive(true); 
               break;
           case 10 :
               Cards[10].SetActive(true);
               break;
           case 11 :
               Cards[11].SetActive(true);
               break;
           case 12 :
               Cards[12].SetActive(true);
               break;
           case 13 :
                Cards[13].SetActive(true);
               break;
           case 14 :
                Cards[14].SetActive(true);
               break;
               
           default:
                Win.SetActive(true);
                Debug.Log("End");
                break; 
       }

       IEnumerator Delayed(float time)
       {
           yield return new WaitForSeconds(1);
       }
       
   }
   
   
   
   
   
}
