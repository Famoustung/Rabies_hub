using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveStageScore2_2 : MonoBehaviour
{
    public int ScoreStage2_2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SaveStage2_2()
    {
        ScoreStage2_2 = 5;
        PlayerPrefs.SetFloat("ScoreStage2_2", ScoreStage2_2);
        Debug.Log("¤Ðá¹¹¢Í§ScorePreTest = " + ScoreStage2_2);
        if (PlayerPrefs.GetInt("levelAt") <= 3)
        {
            PlayerPrefs.SetInt("levelAt", PlayerPrefs.GetInt("levelAt") + 2);
        }

    }
}
