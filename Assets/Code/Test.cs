using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Test : MonoBehaviour
{
     public TextMeshProUGUI textt;


    public float opacity;
    public float powerSpeed = 20f;
    public bool Isfull = false;
    void Update()
    {
        textt.alpha = opacity;
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
            if (opacity <= 0.0f)
            {
                Isfull = false;

            }
        }


    }
}
