using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSceneStage04 : MonoBehaviour
{
    public GameObject thisLevelFalse;
    public GameObject nexLevelTrue;
        
        
    // Start is called before the first frame update
    void Start()
    {
            
    }
    
    // Update is called once per frame
    void Update()
    {
           
    }
        
    public void ChangeLevel()
    {
        nexLevelTrue.SetActive(true);
        thisLevelFalse.SetActive(false);
    }
}
