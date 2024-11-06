using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
/*using UnityEngine.UIElements;*/
using UnityEngine.UI;

public class TimeRemainingBar : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private bool buttonPressed;
    public GameObject thisLevel;
    public GameObject Game0ver;
    public Image timer_linear_image;
    /*public Image timer_radial_image;*/
    public float max_time = 5.0f;
    
    private float time_remaining;
    
    // Start is called before the first frame update
    void Start()
    {
        time_remaining = max_time;
    }

    
    
    // Update is called once per frame
    void Update()
    {
        if (buttonPressed)
        {
            if (time_remaining > 0)
            {
                time_remaining -= Time.deltaTime;
                timer_linear_image.fillAmount = time_remaining / max_time;
            }
            else
            {
                Game0ver.SetActive(true);
                thisLevel.SetActive(false);
            }
        }
    }

    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        buttonPressed = true;
    }
    
    void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
    {
        buttonPressed = false;
    }
}
