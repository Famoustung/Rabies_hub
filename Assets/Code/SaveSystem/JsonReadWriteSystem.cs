using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using UnityEngine;

public class JsonReadWriteSystem : MonoBehaviour
{

    private bool Header = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SaveToJson()
    {

        SaveData data = new SaveData();
        data.Gender = PlayerPrefs.GetString("Gender");
        data.Age = PlayerPrefs.GetString("Age");
        data.LevelAt = PlayerPrefs.GetInt("levelAt");
        data.ScorePretest = PlayerPrefs.GetFloat("ScorePreTest");
        data.ScoreStage1 = PlayerPrefs.GetFloat("ScoreStage1");
        data.ScoreStage2_1 = PlayerPrefs.GetFloat("ScoreStage2_1");
        data.ScoreStage2_2 = PlayerPrefs.GetFloat("ScoreStage2_2");
        data.ScoreStage3_1 = PlayerPrefs.GetFloat("ScoreStage3_1");
        data.ScoreStage3_2 = PlayerPrefs.GetFloat("ScoreStage3_2");
        data.ScoreStage4_1 = PlayerPrefs.GetFloat("ScoreStage4_1");
        data.ScoreStage4_2 = PlayerPrefs.GetFloat("ScoreStage4_2");
        data.ScoreStage5 = PlayerPrefs.GetFloat("ScoreStage5");
        data.ScorePostTest = PlayerPrefs.GetFloat("ScorePostTest");
        data.AmountPostTest = PlayerPrefs.GetInt("AmountPostTest");
        data.pretest1 = PlayerPrefs.GetInt("pretest1");
        data.pretest2 = PlayerPrefs.GetInt("pretest2");
        data.pretest3 = PlayerPrefs.GetInt("pretest3");
        data.pretest4 = PlayerPrefs.GetInt("pretest4");
        data.pretest5 = PlayerPrefs.GetInt("pretest5");
        data.pretest6 = PlayerPrefs.GetInt("pretest6");
        data.pretest7 = PlayerPrefs.GetInt("pretest7");
        data.pretest8 = PlayerPrefs.GetInt("pretest8");
        data.pretest9 = PlayerPrefs.GetInt("pretest9");
        data.pretest10 = PlayerPrefs.GetInt("pretest10");
        data.pretest11 = PlayerPrefs.GetInt("pretest11");
        data.pretest12 = PlayerPrefs.GetInt("pretest12");
        data.pretest13 = PlayerPrefs.GetInt("pretest13");
        data.pretest14 = PlayerPrefs.GetInt("pretest14");
        data.pretest15 = PlayerPrefs.GetInt("pretest15");
        data.posttest1 = PlayerPrefs.GetInt("posttest1");
        data.posttest2 = PlayerPrefs.GetInt("posttest2");
        data.posttest3 = PlayerPrefs.GetInt("posttest3");
        data.posttest4 = PlayerPrefs.GetInt("posttest4");
        data.posttest5 = PlayerPrefs.GetInt("posttest5");
        data.posttest6 = PlayerPrefs.GetInt("posttest6");
        data.posttest7 = PlayerPrefs.GetInt("posttest7");
        data.posttest8 = PlayerPrefs.GetInt("posttest8");
        data.posttest9 = PlayerPrefs.GetInt("posttest9");
        data.posttest10 = PlayerPrefs.GetInt("posttest10");
        data.posttest11 = PlayerPrefs.GetInt("posttest11");
        data.posttest12 = PlayerPrefs.GetInt("posttest12");
        data.posttest13 = PlayerPrefs.GetInt("posttest13");
        data.posttest14 = PlayerPrefs.GetInt("posttest14");
        data.posttest15 = PlayerPrefs.GetInt("posttest15");

        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(Application.dataPath + "/SaveDataFile.json", json);

    }

    // public int Pretest1, pretest2, pretest3, pretest4, pretest5, Pretest6, pretest7, pretest8, pretest9, Pretest10, pretest11;
    //  public int Posttest1, posttest2, posttest3, posttest4, posttest5, Posttest6, posttest7, posttest8, posttest9, Posttest10, posttest11;

    public  void SaveDataToCSV()
    {
        SaveData data = new SaveData();
        data.Age = PlayerPrefs.GetString("Age");
        data.Gender = PlayerPrefs.GetString("Gender");
        data.LevelAt = PlayerPrefs.GetInt("levelAt");
        data.ScorePretest = PlayerPrefs.GetFloat("ScorePreTest");
        data.ScoreStage1 = PlayerPrefs.GetFloat("ScoreStage1");
        data.ScoreStage2_1 = PlayerPrefs.GetFloat("ScoreStage2_1");
        data.ScoreStage2_2 = PlayerPrefs.GetFloat("ScoreStage2_2");
        data.ScoreStage3_1 = PlayerPrefs.GetFloat("ScoreStage3_1");
        data.ScoreStage3_2 = PlayerPrefs.GetFloat("ScoreStage3_2");
        data.ScoreStage4_1 = PlayerPrefs.GetFloat("ScoreStage4_1");
        data.ScoreStage4_2 = PlayerPrefs.GetFloat("ScoreStage4_2");
        data.ScoreStage5 = PlayerPrefs.GetFloat("ScoreStage5");
        data.ScorePostTest = PlayerPrefs.GetFloat("ScorePostTest");
        data.AmountPostTest = PlayerPrefs.GetInt("AmountPostTest");
        data.pretest1 = PlayerPrefs.GetInt("pretest1");
        data.pretest2 = PlayerPrefs.GetInt("pretest2");
        data.pretest3 = PlayerPrefs.GetInt("pretest3");
        data.pretest4 = PlayerPrefs.GetInt("pretest4");
        data.pretest5 = PlayerPrefs.GetInt("pretest5");
        data.pretest6 = PlayerPrefs.GetInt("pretest6");
        data.pretest7 = PlayerPrefs.GetInt("pretest7");
        data.pretest8 = PlayerPrefs.GetInt("pretest8");
        data.pretest9 = PlayerPrefs.GetInt("pretest9");
        data.pretest10 = PlayerPrefs.GetInt("pretest10");
        data.pretest11 = PlayerPrefs.GetInt("pretest11");
        data.pretest12 = PlayerPrefs.GetInt("pretest12");
        data.pretest13 = PlayerPrefs.GetInt("pretest13");
        data.pretest14 = PlayerPrefs.GetInt("pretest14");
        data.pretest15 = PlayerPrefs.GetInt("pretest15");
        data.posttest1 = PlayerPrefs.GetInt("posttest1");
        data.posttest2 = PlayerPrefs.GetInt("posttest2");
        data.posttest3 = PlayerPrefs.GetInt("posttest3");
        data.posttest4 = PlayerPrefs.GetInt("posttest4");
        data.posttest5 = PlayerPrefs.GetInt("posttest5");
        data.posttest6 = PlayerPrefs.GetInt("posttest6");
        data.posttest7 = PlayerPrefs.GetInt("posttest7");
        data.posttest8 = PlayerPrefs.GetInt("posttest8");
        data.posttest9 = PlayerPrefs.GetInt("posttest9");
        data.posttest10 = PlayerPrefs.GetInt("posttest10");
        data.posttest11 = PlayerPrefs.GetInt("posttest11");
        data.posttest12 = PlayerPrefs.GetInt("posttest12");
        data.posttest13 = PlayerPrefs.GetInt("posttest13");
        data.posttest14 = PlayerPrefs.GetInt("posttest14");
        data.posttest15 = PlayerPrefs.GetInt("posttest15");


        string filePath = Application.dataPath + "/SaveData.csv";

        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            
            if (PlayerPrefs.GetInt("Header") == 0)
            {
                if (!Header)
                {
                    // Write header row with property names
                    writer.WriteLine("Gender,Age,LevelAt,ScorePretest,ScoreStage1,ScoreStage2_1,ScoreStage2_2,ScoreStage3_1,ScoreStage3_2,ScoreStage4_1,ScoreStage4_2,ScoreStage5,ScorePostTest,AmountPostTest,pretest1,pretest2,pretest3,pretest4,pretest5,pretest6,pretest7,pretest8,pretest9,pretest10,pretest11,pretest11,pretest13,pretest14,pretest15,Posttest1,Posttest2,posttest3,posttest4,posttest5,posttest6,posttest7,posttest8,posttest9,posttest10,posttest11,posttest12,posttest13,posttest14,posttest15"); // Add other property names
                    Header = true;
                    PlayerPrefs.SetInt("Header",1);
                }
            }

        
        
            // Write data values to CSV
        
            writer.WriteLine($"{data.Gender},{data.Age},{data.LevelAt},{data.ScorePretest},{data.ScoreStage1},{data.ScoreStage2_1},{data.ScoreStage2_2},{data.ScoreStage3_1},{data.ScoreStage3_2},{data.ScoreStage4_1},{data.ScoreStage4_2},{data.ScoreStage5},{data.ScorePostTest},{data.AmountPostTest},{data.pretest1},{data.pretest2},{data.pretest3},{data.pretest4},{data.pretest5},{data.pretest6},{data.pretest7},{data.pretest8},{data.pretest9},{data.pretest10},{data.pretest11},{data.pretest12},{data.pretest13},{data.pretest14},{data.pretest15},{data.posttest1},{data.posttest2},{data.posttest3},{data.posttest4},{data.posttest5},{data.posttest6},{data.posttest7},{data.posttest8},{data.posttest9},{data.posttest10},{data.posttest11},{data.posttest12},{data.posttest13},{data.posttest14},{data.posttest15}"); // Add other data values
        }
        Debug.Log("Data saved to CSV file: " + filePath);
    }
}
