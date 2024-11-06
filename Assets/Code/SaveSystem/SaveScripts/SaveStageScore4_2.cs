using System.Collections;
using System.Collections.Generic;
using TrafficRacer;
using UnityEngine;

public class SaveStageScore4_2 : MonoBehaviour
{
    public int ScoreStage4_2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // ScoreStage4_2 = GameObject.Find("LevelManager").GetComponent<LevelManager>().distanceTravelled;
    }
    public void SaveStage4_2()
    {
        ScoreStage4_2 = 5;
        PlayerPrefs.SetFloat("ScoreStage4_2", ScoreStage4_2);
        Debug.Log("¤Ðá¹¹¢Í§ScorePreTest = " + ScoreStage4_2);
        if (PlayerPrefs.GetInt("levelAt") == 7)
        {
            PlayerPrefs.SetInt("levelAt", PlayerPrefs.GetInt("levelAt") + 1);
        }

    }
}
