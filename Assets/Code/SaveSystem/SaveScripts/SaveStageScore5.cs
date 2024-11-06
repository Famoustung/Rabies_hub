using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveStageScore5 : MonoBehaviour
{

    public int ScoreStage5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SaveStage5()
    {
        ScoreStage5 = 5;
        PlayerPrefs.SetFloat("ScoreStage5", ScoreStage5);
        Debug.Log("¤Ðá¹¹¢Í§ScorePreTest = " + ScoreStage5);
        if (PlayerPrefs.GetInt("levelAt") == 8)
        {
            PlayerPrefs.SetInt("levelAt", PlayerPrefs.GetInt("levelAt") + 1);
        }

    }
}
