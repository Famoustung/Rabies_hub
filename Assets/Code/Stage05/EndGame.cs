using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
    public GameObject video1;
    public GameObject video2;
    public GameObject[] BodyLevel01;
    public GameObject[] BodyLevel02;
    public GameObject[] Level01;
    public GameObject[] Level02;
    public GameObject[] Level03;

    [Header("PowerBar")]
    public Slider imagePower;
    public float amtPower;

    public GameObject gameOver;
    // Start is called before the first frame update
    void Start()    
    {
        //video1.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        imagePower.value = amtPower;
        // Level01 --------------------------------------------------------
        for ( int i = 0 ; i < BodyLevel01.Length; ++i) 
        {
            if (BodyLevel01[0] == false && 
                BodyLevel01[1] == false && 
                BodyLevel01[2] == false && 
                BodyLevel01[3] == false && 
                BodyLevel01[4] == false)
            {
                Debug.Log("Level02");
                if (Level02[0].activeInHierarchy == false && 
                    Level02[1].activeInHierarchy == false &&
                    Level03[0].activeInHierarchy == false &&
                    Level03[1].activeInHierarchy == false && 
                    gameOver.activeInHierarchy == false)
                {
                    Debug.Log("Level02 == false");
                    Level01[0].SetActive(false);
                    Level01[1].SetActive(true);
                }
            }
        }    
        // Level01 --------------------------------------------------------
        
        // Level02 --------------------------------------------------------
        for (int i = 0; i < BodyLevel02.Length; ++i)
        {
            if (BodyLevel02[0] == false)
            {   if (Level03[0].activeInHierarchy == false)
                {
                    Level02[0].SetActive(false);
                    Level02[1].SetActive(true);
                }
            }
        }
        // Level02 --------------------------------------------------------
        
        // Level03 --------------------------------------------------------
        
        
        
        // Level03 --------------------------------------------------------
        
    }
    
    
}
