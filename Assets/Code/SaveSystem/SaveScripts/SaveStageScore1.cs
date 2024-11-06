using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveStageScore1 : MonoBehaviour
{

    public int ScoreStage1;
    
   
    
    
    
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // ScoreStage1 = GameObject.Find("GameManager").GetComponent<ManagerScore>().score;
    }

    public void SaveStage1()
    {
        ScoreStage1 = 5;
        PlayerPrefs.SetFloat("ScoreStage1", ScoreStage1);
        Debug.Log("¤Ðá¹¹¢Í§ScorePreTest = " + ScoreStage1);
        if (PlayerPrefs.GetInt("levelAt") == 1)
        {
            PlayerPrefs.SetInt("levelAt", PlayerPrefs.GetInt("levelAt") + 1);
        }

    }
    
    
   
   
   
   
 

}
