using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{

    private void Start()
    {
        SoundManager.Instance.PlaySoundBgm(SoundType.bgm01,true);
    }
    void Update()
    {
        
    }
    public void StageSelect()
    {
        PlayerPrefs.SetInt("Header", 0);
        SceneManager.LoadScene("StageSelections");
        
        PlayerPrefs.SetFloat("ScorePreTest", 0);
        PlayerPrefs.SetFloat("ScoreStage1", 0);
        PlayerPrefs.SetFloat("ScoreStage2_1", 0);
        PlayerPrefs.SetFloat("ScoreStage2_2", 0);
        PlayerPrefs.SetFloat("ScoreStage3_1", 0);
        PlayerPrefs.SetFloat("ScoreStage3_2", 0);
        PlayerPrefs.SetFloat("ScoreStage4_1", 0);
        PlayerPrefs.SetFloat("ScoreStage4_2", 0);
        PlayerPrefs.SetFloat("ScoreStage5", 0);
        PlayerPrefs.SetFloat("ScorePostTest", 0);
        PlayerPrefs.SetInt("AmountPostTest", 0);
        PlayerPrefs.SetInt("Pretest1", 0);
        PlayerPrefs.SetInt("Pretest2", 0);
        PlayerPrefs.SetInt("pretest3", 0);
        PlayerPrefs.SetInt("pretest4", 0);
        PlayerPrefs.SetInt("pretest5", 0);
        PlayerPrefs.SetInt("pretest6", 0);
        PlayerPrefs.SetInt("pretest7", 0);
        PlayerPrefs.SetInt("pretest8", 0);
        PlayerPrefs.SetInt("pretest9", 0);
        PlayerPrefs.SetInt("pretest10", 0);
        PlayerPrefs.SetInt("pretest11", 0);
        PlayerPrefs.SetInt("Posttest1", 0);
        PlayerPrefs.SetInt("Posttest2", 0);
        PlayerPrefs.SetInt("posttest3", 0);
        PlayerPrefs.SetInt("posttest4", 0);
        PlayerPrefs.SetInt("posttest5", 0);
        PlayerPrefs.SetInt("posttest6", 0);
        PlayerPrefs.SetInt("posttest7", 0);
        PlayerPrefs.SetInt("posttest8", 0);
        PlayerPrefs.SetInt("posttest9", 0);
        PlayerPrefs.SetInt("posttest10", 0);
        PlayerPrefs.SetInt("posttest11", 0);

    }
}
