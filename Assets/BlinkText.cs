using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BlinkText : MonoBehaviour
{
    public TextMeshProUGUI text;
     
    
    public float opacity;
    public float powerSpeed = 20f;
    public bool Isfull = false;

    void Start()
    {
        
    }

    void Update()
    {
        text.alpha = opacity; 
        if (!Isfull)
        {
            opacity += Time.deltaTime * powerSpeed;
            if (opacity >= 1f)
            {
                Isfull = true;
                
            } 
        }
        else if (Isfull)
        {
            opacity -= Time.deltaTime * powerSpeed; 
            if (opacity <= 0.0f )
            {
                Isfull = false;
                        
            }
        }
    }
}
