using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void PlayAgain()
    {
        SceneManager.LoadScene("Stage05");
    }

    public void changeMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    
    public void changeStage5Yo()
    {
        SceneManager.LoadScene("Stage5Yo");
    }
    
    public void changeStageDropDog()
    {
        SceneManager.LoadScene("StageDropDog");
    }
    
    public void StageSelections()
    {
        SceneManager.LoadScene("StageSelections");
    }
    public void NextStage()
    {
        SceneManager.LoadScene("Stage2_Level_2");
    }
}
