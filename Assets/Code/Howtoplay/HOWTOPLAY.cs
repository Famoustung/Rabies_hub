using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HOWTOPLAY : MonoBehaviour
{
    public GameObject[] objects;
    public int currentIndex = 0;

    public GameObject thisScene;

    public GameObject NextBTN;
    public GameObject BackBTN;
    public GameObject CloseBTN;
    
    
    void Start()
    { 
        
        NextBTN.SetActive(true);
        BackBTN.SetActive(false); 
        CloseBTN.SetActive(false); 
        
        // ตั้งค่าค่าเริ่มต้นของ Index ให้เป็น 0
        currentIndex = 0;

        // Activate วัตถุตัวแรกใน Array
        objects[currentIndex].SetActive(true);

        Time.timeScale = 1;
    }

    public void Update()
    {
        if (currentIndex == objects.Length -1)
        {
            NextBTN.SetActive(false);
            CloseBTN.SetActive(true);
            
        }
        else if ( currentIndex < objects.Length -1 )
        {
            CloseBTN.SetActive(false);
           
        }
        
        if (currentIndex == 0 )
        {
            BackBTN.SetActive(false);
            NextBTN.SetActive(true);
        }
        else if (currentIndex >= 1 && currentIndex < objects.Length-1)
        {
            BackBTN.SetActive(true);
            NextBTN.SetActive(true);
        }
        
        
       
        
    }

    public void OnNextButtonClick()
    {
        // ตรวจสอบว่า Index อยู่ท้ายสุดของ Array หรือไม่
        if (currentIndex == objects.Length - 1)
        {
            // ถ้าใช่ ให้ตั้งค่า Index ให้เป็น 0
            currentIndex = 0;
        }
        else
        {
            // ถ้าไม่ใช่ ให้เพิ่ม Index ขึ้น 1
            currentIndex++;
        }

        // Activate วัตถุที่ Index ใหม่
        objects[currentIndex].SetActive(true);

        // Set active False ให้กับ Array ก่อนหน้า
        if (currentIndex > 0)
        {
            objects[currentIndex - 1].SetActive(false);
        }
    }

   public void OnPreviousButtonClick()
    {
        // ตรวจสอบว่า Index อยู่ต้น Array หรือไม่
        if (currentIndex == 0)
        {
            // ถ้าใช่ ให้ตั้งค่า Index ให้เป็นท้ายสุดของ Array
            currentIndex = objects.Length - 1;
        }
        else
        {
            // ถ้าไม่ใช่ ให้ลด Index ลง 1
            currentIndex--;
        }

        // Activate วัตถุที่ Index ใหม่
        objects[currentIndex].SetActive(true);

        // Set active False ให้กับ Array ก่อนหน้า
        if (currentIndex < objects.Length - 1)
        {
            objects[currentIndex + 1 ].SetActive(false);
        }
    }
    
   public void OnCloseButtonClick()
   {
       Time.timeScale = 1;
        // ปิดหน้าต่าง
        thisScene.SetActive(false);
    }
}
