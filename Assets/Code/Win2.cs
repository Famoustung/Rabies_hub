using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win2 : MonoBehaviour
{
    
    public float ScoreStage2;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void StageSelect()
    {
        Time.timeScale = 1f;
        PlayerPrefs.SetFloat("ScoreStage2",ScoreStage2);
        Debug.Log("คะแนนของด่าน 2 = "+ScoreStage2);
        if (PlayerPrefs.GetInt("levelAt") == 2)
        {
            PlayerPrefs.SetInt("levelAt", PlayerPrefs.GetInt("levelAt") + 1 );
        }
        
        SceneManager.LoadScene("StageSelections");
    }
    
    
    
    public void NextStage()
    {
        Time.timeScale = 1f;
        PlayerPrefs.SetFloat("ScoreStage2", ScoreStage2);
        Debug.Log("คะแนนของด่าน 2 = "+ ScoreStage2);
        if (PlayerPrefs.GetInt("levelAt") == 2)
        {
            PlayerPrefs.SetInt("levelAt", PlayerPrefs.GetInt("levelAt") + 1 );
        }
       
        SceneManager.LoadScene("Stage03");
    }
}
