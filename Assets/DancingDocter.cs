using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DancingDocter : MonoBehaviour
{
    public GameObject chara;
    public float bounceHeight = 0.1f;
    public float bounceSpeed = 2f;
    public float delayTime = 5f;

    private float initialY;
    private bool isBouncing = false;
    private float elapsedTime = 0f;

    private void Start()
    {
        initialY = chara.gameObject.transform.position.y;
        StartBouncing();
    }

    public void StartBouncing()
    {
        isBouncing = true;
        elapsedTime = 0f;
    }

    public void StopBouncing()
    {
        isBouncing = false;
        chara.transform.position = new Vector3(transform.position.x, initialY, transform.position.z);
    }

    private void Update()
    {
        if (!isBouncing && elapsedTime < delayTime)
        {
            elapsedTime += Time.deltaTime;
        }
        else if (isBouncing)
        {
            float bounceAmount = Mathf.Sin(Time.time * bounceSpeed) * bounceHeight;
            chara.gameObject.transform.position = new Vector3(transform.position.x, initialY + bounceAmount, transform.position.z);
        }
    }
}
