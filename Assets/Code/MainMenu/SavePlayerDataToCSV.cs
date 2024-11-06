using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class SavePlayerDataToCSV : MonoBehaviour
{
    public InputField input;

    // Use this for initialization
    void Start()
    {

    }

    
    public string Gender;
    public string Age;
    public TMP_Text GenderField_;
    public TMP_Text AgeField_;
    public GameObject thisScene;
    public GameObject debug;
    public bool a = false;
    public void Update()
    {
        Gender = GenderField_.text;
        Age = AgeField_.text;
    }

    public void Open()
    {
        if (!a)
        {
            debug.SetActive(true);
            a = true;
        }
        else
        {
            debug.SetActive(false);
            a = false;
        }

    }
    public void SaveName()
    {
        PlayerPrefs.SetString("Gender", Gender);
        PlayerPrefs.SetString("Age", Age);
    }

}
