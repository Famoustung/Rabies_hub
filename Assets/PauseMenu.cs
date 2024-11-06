using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

  public GameObject PopUp;
  
  
  
  private void Update()
  {
    
  }


  public void OpenPauseMenu()
  {
    PopUp.SetActive(true);
    
  }

  public void ClosePauseMenu()
  {
    PopUp.SetActive(false);
  }

  public void GoToMenu()
  {
    
    PopUp.SetActive(false);

    SceneManager.LoadScene("StageSelections");
  }
  
}
