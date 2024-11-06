using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveTest2 : MonoBehaviour
{
    public float ScorePostTest;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ScorePostTest = GameObject.Find("GameManagerQuestions").GetComponent<QuestionManagerFix>().score;
    }
    public void SavePostTest()
    {
        PlayerPrefs.SetFloat("ScorePostTest", ScorePostTest);
        Debug.Log("¤Ðá¹¹¢Í§ScorePostTest = " + ScorePostTest);
        if (PlayerPrefs.GetInt("levelAt") == 9)
        {
            PlayerPrefs.SetInt("levelAt", PlayerPrefs.GetInt("levelAt") + 1);
        }

    }
}
