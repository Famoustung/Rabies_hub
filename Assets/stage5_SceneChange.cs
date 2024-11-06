using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class stage5_SceneChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Load_Next()
    {
        SceneManager.LoadScene("Stage05-2");
    }

    public void Load_Menu()
    {
        SceneManager.LoadScene("StageSelections");
    }
}
