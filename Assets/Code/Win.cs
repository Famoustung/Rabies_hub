using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    enum SceneName
    {
        MainMenu,
        StageSelections,
        Stage01,
        Stage2_Level_1,
        Stage2_Level_2,
        Stage3_StageDropDog,
        Stage3_StageShuffle,
        Stage04,
        Stage05,
        Stage05_2,
        Stage6,
        Ending,
        
    }

    
    
    [SerializeField] SceneName NextSceneName;
    [SerializeField] SceneName MenuName;

    public void NextStageButton()
    {
        SceneManager.LoadScene(""+ NextSceneName);
    }

    public void Menu()
    {
        SceneManager.LoadScene(""+ MenuName); 
    }

    public void GoPostTest()
    {
        SceneManager.LoadScene("Post-tests");
    }
}
