using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveStageScore3_2 : MonoBehaviour
{
    public int ScoreStage3_2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ScoreStage3_2 = GameObject.Find("GameManager").GetComponent<GameManager2>().score;
    }
    public void SaveStage3_2()
    {
        PlayerPrefs.SetFloat("ScoreStage3_2", ScoreStage3_2);
        Debug.Log("¤Ðá¹¹¢Í§ScorePreTest = " + ScoreStage3_2);
        if (PlayerPrefs.GetInt("levelAt") == 5)
        {
            PlayerPrefs.SetInt("levelAt", PlayerPrefs.GetInt("levelAt") + 1);
        }

    }
}
