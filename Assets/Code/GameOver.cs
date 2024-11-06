using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    enum SceneName
    {
        Menu,
        StageSelections,
        Stage1,
        Stage2_Level_1,
        Stage2_Level_2,
        Stage3_StageDropDog,
        Stage3_StageShuffle,
        Stage4,
        Stage05,
        Stage6
    }
    
   
    [SerializeField] SceneName RestartSceneName;
    [SerializeField] SceneName MenuName;

    public void NextStageButton()
    {
        SceneManager.LoadScene(""+ RestartSceneName);
    }

    public void Menu()
    {
        SceneManager.LoadScene(""+ MenuName); 
    } 
}
