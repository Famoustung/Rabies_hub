using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerDestroy : MonoBehaviour
{
    public GameObject[] Chosses;
    // Start is called before the first frame update
    public GameObject pic;
    public GameObject pic2;
    public float timeBetweenQuestions = 0.1f;
    

    public void Start()
    {
       pic.SetActive(true);
       pic2.SetActive(true);
    }

    private void Update()
    {
        
    }

    public void Tigger()
    {
        
        if (!pic.activeInHierarchy)
        {
            pic.SetActive(true);
            pic2.SetActive(true);

        }
        else if (pic.activeInHierarchy)
        {
            pic.SetActive(false);
            pic2.SetActive(false);
            
            StartCoroutine(WaitAndSetActive()); 
        }
        
    }

    IEnumerator WaitAndSetActive()
    {
        yield return new WaitForSeconds(timeBetweenQuestions);
        pic.SetActive(true);
        pic2.SetActive(true);
        
    }
}