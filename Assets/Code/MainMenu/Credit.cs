using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnterCredit()
    {
        SceneManager.LoadScene("Credit");
    }

    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
