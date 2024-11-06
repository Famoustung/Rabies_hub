using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveStageScore4_1 : MonoBehaviour
{
    public int ScoreStage4_1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // ScoreStage4_1 = GameObject.Find("GameManager").GetComponent<ScoreManager>().score;
    }
    public void SaveStage4_1()
    {
        ScoreStage4_1 = 5;
        PlayerPrefs.SetFloat("ScoreStage4_1", ScoreStage4_1);
        Debug.Log("¤Ðá¹¹¢Í§ScorePreTest = " + ScoreStage4_1);
        if (PlayerPrefs.GetInt("levelAt") == 6)
        {
            PlayerPrefs.SetInt("levelAt", PlayerPrefs.GetInt("levelAt") + 1);
        }

    }
}
