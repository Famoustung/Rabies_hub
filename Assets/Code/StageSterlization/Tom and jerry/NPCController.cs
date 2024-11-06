using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour
{
    public float moveSpeed = 2f; // ความเร็วในการเคลื่อนที่
    public Transform[] waypoints; // จุดหมายปลายทาง
    public int currentWaypointIndex = 0; // ดัชนีจุดหมายปลายทางปัจจุบัน
    private bool Return;
    private Rigidbody2D rb;

    public bool canWalk = true;

    public SpriteRenderer SpriteRendererFlip;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        SpriteRendererFlip = GetComponent<SpriteRenderer>();
        
    }

   

    void FixedUpdate()
    {
        SpriteRendererFlip = GetComponent<SpriteRenderer>(); 
            // เคลื่อนที่ไปยังจุดหมายปลายทาง
            Vector2 direction = waypoints[currentWaypointIndex].position - transform.position;
            direction.Normalize();
            rb.velocity = direction * moveSpeed;


            if (Return)
            {
                SpriteRendererFlip.flipX = true;
            }
            else if (!Return)
            {
                SpriteRendererFlip.flipX = false;
            }
        

                if (canWalk)
        {
            // ตรวจสอบว่าถึงจุดหมายปลายทางแล้วหรือไม่
            if (Vector2.Distance(transform.position, waypoints[currentWaypointIndex].position) < 0.1f)
            {

                if (!Return)
                {
                    currentWaypointIndex++;
                    
                }
                else if (Return)
                {
                    currentWaypointIndex--;
                    
                }
            
            
                if (currentWaypointIndex >= waypoints.Length)
                {
                    currentWaypointIndex = 3;
                    Return = true;
                }

                if (currentWaypointIndex == 0)
                {
                    currentWaypointIndex = 0;
                    Return = false;
                }
            } 
        }
        else if (!canWalk)
        {
            rb.velocity = new Vector2(0f, 0f);
        }
        
       
        
        
        
    }
    
    
    
    
}
