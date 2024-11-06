using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveStageScore2_1 : MonoBehaviour
{
    public int ScoreStage2_1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SaveStage2_1()
    {
        PlayerPrefs.SetFloat("ScoreStage2_1", ScoreStage2_1);
        Debug.Log("¤Ðá¹¹¢Í§ScorePreTest = " + ScoreStage2_1);
        if (PlayerPrefs.GetInt("levelAt") == 2)
        {
            PlayerPrefs.SetInt("levelAt", PlayerPrefs.GetInt("levelAt") + 1);
        }

    }
}
