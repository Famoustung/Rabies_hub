using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PickButton : MonoBehaviour
{

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.Space)) {
            OnPointerClick();
        }
    }


    private bool Iscarrying = false;
    
    public void OnPointerClick()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        Iscarrying = player.GetComponent<GrabController>().IsCarrying;
        
        if (!Iscarrying)
        {
            player.GetComponent<GrabController>().PickUpObject(); 
        }
        else if(Iscarrying)
        {
            player.GetComponent<GrabController>().DropObject(); 
        }
        
        
    }
}
