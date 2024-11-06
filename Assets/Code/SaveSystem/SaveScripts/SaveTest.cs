using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveTest : MonoBehaviour
{

    public float ScorePreTest;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //GameManagerQuestions
        ScorePreTest = GameObject.Find("GameManagerQuestions").GetComponent<QuestionManagerFix>().score;
    }

    public void SavePreTest()
    {
        PlayerPrefs.SetFloat("ScorePreTest", ScorePreTest);
        Debug.Log("¤Ðá¹¹¢Í§ScorePreTest = " + ScorePreTest);
        if (PlayerPrefs.GetInt("levelAt") == 0)
        {
            PlayerPrefs.SetInt("levelAt", PlayerPrefs.GetInt("levelAt") + 1);
        }

    }

    


}
