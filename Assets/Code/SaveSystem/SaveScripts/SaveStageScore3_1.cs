using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveStageScore3_1 : MonoBehaviour
{
    public int ScoreStage3_1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ScoreStage3_1 = GameObject.Find("GameManager").GetComponent<GameManagerStage01>().score;
    }
    public void SaveStage3_1()
    {
        PlayerPrefs.SetFloat("ScoreStage3_1", ScoreStage3_1);
        Debug.Log("¤Ðá¹¹¢Í§ScorePreTest = " + ScoreStage3_1);
        if (PlayerPrefs.GetInt("levelAt") == 4)
        {
            PlayerPrefs.SetInt("levelAt", PlayerPrefs.GetInt("levelAt") + 1);
        }

    }
}
