using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pretest : MonoBehaviour
{

   private float score;

   public void stage1()
   {
      Time.timeScale = 1;

      score = GameObject.Find("GameManagerQuestions").GetComponent<QuestionManagerFix>().score;
      
      PlayerPrefs.SetFloat("ScorePreTest",score);
      if (PlayerPrefs.GetInt("levelAt") == 0)
      {
         PlayerPrefs.SetInt("levelAt", PlayerPrefs.GetInt("levelAt") + 1 );
      } 
      SceneManager.LoadScene("StageSelections"); 
   }
}
