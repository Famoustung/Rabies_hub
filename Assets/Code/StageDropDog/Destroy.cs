using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject HowToPlay,Manager1,Manager2;
    private Spawner spawner;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!HowToPlay.activeInHierarchy)
        {
            Manager1.SetActive(true);
            Manager2.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        spawner = GameObject.Find("Spawner").GetComponent<Spawner>();
        if (other.gameObject.name == ("Animal 5(Clone)") || 
            other.gameObject.name == ("Animal 6(Clone)") || 
            other.gameObject.name == ("Animal 7(Clone)") || 
            other.gameObject.name == ("Animal 8(Clone)") || 
            other.gameObject.name == ("Animal 9(Clone)")  
        )
        {
            
            spawner.SpawnQuestObj();
            Debug.Log("spawn");
        }
        Debug.Log(""+other.gameObject.name);
        Destroy(other.gameObject);  
        
    }
}
