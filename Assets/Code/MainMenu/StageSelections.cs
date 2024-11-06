    using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StageSelections : MonoBehaviour
{

    public GameObject[] selectButton1;
    public GameObject[] selectButton2;

    public GameObject next;
    public GameObject back;
    
    public Button[] lvlButtons;
    
    public int nextSceneLoad;

    public int levelAt;
    public GameObject[] Bg;
    // Start is called before the first frame update
    void Start()
    {
       levelAt = PlayerPrefs.GetInt("levelAt");
       Debug.Log(levelAt); 
       
       
       
       for (int i = 0; i < selectButton2.Length; i++)
       {
           selectButton2[i].SetActive(false);
       } 
    }

    private void Update()
    {
      

      /*  lvlButtons[0].interactable = true;
        lvlButtons[1].interactable = true;
        lvlButtons[2].interactable = true;
        lvlButtons[3].interactable = true;
        lvlButtons[4].interactable = false;
        lvlButtons[5].interactable = true;
        lvlButtons[6].interactable = true;
        lvlButtons[7].interactable = true; 
        lvlButtons[8].interactable = true; 
        lvlButtons[9].interactable = true;  */
        
        levelAt = PlayerPrefs.GetInt("levelAt");

        if (levelAt >= 0) //pre-test
        {
            lvlButtons[0].interactable = true;
        
     
        }
        
      if (levelAt >= 1) //Stage1
       {
          
           lvlButtons[1].interactable = true;
       

       }
       if (levelAt >= 2) //Stage2
       {
          
           lvlButtons[2].interactable = true;
    
          
       }
       if (levelAt >= 4) //Stage3
       {
          
           lvlButtons[3].interactable = true;
     
        
       }
       if (levelAt >= 6) //Stage4
       {
        
           lvlButtons[4].interactable = true;
        
       
          
       }
       if (levelAt >= 8) //stage5
       {
           
           lvlButtons[5].interactable = true;
           
       
           
       }
       if (levelAt >= 9) //stage6
       {
           
           lvlButtons[6].interactable = true;
       
           
       }
       
     
    }

    public void NextPage()
    {
        for (int i = 0; i < selectButton1.Length; i++)
        {
            selectButton1[i].SetActive(false);
            Bg[0].SetActive(false);
        }

        for (int i = 0; i < selectButton2.Length; i++)
        {
            selectButton2[i].SetActive(true);
            Bg[1].SetActive(true);
        }
        
        next.SetActive(false);
        back.SetActive(true);
    }

    public void BackPage()
    {
        for (int i = 0; i < selectButton1.Length; i++)
        {
            selectButton1[i].SetActive(true);
            Bg[0].SetActive(true);
        }

        for (int i = 0; i < selectButton2.Length; i++)
        {
            selectButton2[i].SetActive(false);
            Bg[1].SetActive(false);
        } 
        
        next.SetActive(true);
        back.SetActive(false);
    }
    
    public void MainMenu_Warp()
    {
        SceneManager.LoadScene("MainMenu");
    }
    
    public void Options_Warp()
    {
        SceneManager.LoadScene("Options");
    }
    
    public void StageSelect()
    {
        nextSceneLoad = 0; 
        
        PlayerPrefs.SetInt("levelAt", nextSceneLoad);
        
        SceneManager.LoadScene("StageSelections");
    }
    
    public void PreTest()
    {
        Debug.Log("Pre-tests");
        SceneManager.LoadScene("Pre-tests");
    }
    
    public void Stage01_Situation01_1_Warp()
    {
        Debug.Log("Stage01");
        SceneManager.LoadScene("Stage01");
    }
    
    public void Stage02_warp()
    {
        Debug.Log("Stage02");
        SceneManager.LoadScene("Stage2_Level_1");
    }
    public void Stage03_warp()
    {
        Debug.Log("Stage03");
        SceneManager.LoadScene("Stage3_StageDropDog");
    }
    public void Stage04_warp()
    {
        Debug.Log("Stage04");
        SceneManager.LoadScene("Stage04");
    }
    public void Stage05_warp()
    {
        Debug.Log("Stage05");
        SceneManager.LoadScene("Stage05");
    }
    public void Stage06_warp()
    {
        Debug.Log("Stage06");
        SceneManager.LoadScene("Stage6");
    }

    public void PostTest()
    {
        Debug.Log("PostTest");
        SceneManager.LoadScene("Post-tests"); 
    }
}
