using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    public GameObject spawnerObj;
    public GameObject[] prefabs;
    public float spawnRate;
    public int minCount;
    public int maxCount;
   
    // กำหนดค่าขอบเขตพื้นที่
    public float minX = -1;
    public float maxX = 1;


    
    public bool start = true;
    
    // เพิ่มระบบเวลา
    public float gameTime;

    // เพิ่มตำแหน่ง Spawn
    public Vector3 spawnPosition;

    public GameObject win;
    public GameObject end;
    public GameObject destroyObj;
    void Awake()
    {

        if (start)
        {
            
            InvokeRepeating("SpawnObject", spawnRate, spawnRate); 
            
        }
        
        
    }

    private void Update()
    {
        if (end.activeInHierarchy || win.activeInHierarchy)
        {
            CancelInvoke("SpawnObject"); 
           
            destroyObj.gameObject.SetActive(false);
        }
        
        
        

    }


    void SpawnObject()
    {
        
        // กำหนดจำนวนวัตถุที่จะ spawn
        int count = Random.Range(minCount, maxCount);

        // วนซ้ำเพื่อ spawn วัตถุ
        for (int i = 0; i < count; i++)
        {
            // เลือกวัตถุที่จะ spawn
            int index = Random.Range(0, prefabs.Length);
            GameObject obj = prefabs[index];

            // กำหนดตำแหน่ง Spawn แบบสุ่ม
            Vector2 spawnPoint = new Vector2(Random.Range(minX, maxX),10);

            // กำหนดทิศทาง spawn
            GameObject instance = Instantiate(obj, spawnPoint, transform.rotation);

            // เพิ่มเวลา spawn
            
        }
    }

    public void SpawnQuestObj()
    {
        int count = Random.Range(0, 4);
        
            // เลือกวัตถุที่จะ spawn
            int index = Random.Range(0, prefabs.Length);
            GameObject obj = prefabs[index];

            // กำหนดตำแหน่ง Spawn แบบสุ่ม
            Vector2 spawnPoint = new Vector2(Random.Range(minX, maxX),10);

            // กำหนดทิศทาง spawn
            GameObject instance = Instantiate(obj, spawnPoint, transform.rotation);

            // เพิ่มเวลา spawn
            
         
        
    }
}