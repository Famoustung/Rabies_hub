using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public bool manager  = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("GameManager").GetComponent<Stage6>().Istrigger = true;
        Debug.Log("trigger");
        manager = true;
    }

    
}
