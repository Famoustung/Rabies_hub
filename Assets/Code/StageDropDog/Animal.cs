using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class Animal : MonoBehaviour
{
    private bool isDragging = false;
    private Vector3 initialPosition;
    private Vector3 startPosition;
    public Transform dropArea; // Reference to the drop area transform
    public int points = 1; // Points gained when object is dropped in the correct area

  
    //public TextMeshPro scoreText;
    public int scoreValue = 10;

    public int speed;

    public int animalnumber;
    public GameManagerStage01 stage01;
    public GameObject damageText;
    public GameObject takeDamage;

//    public SpriteRenderer indicator1;
//    public SpriteRenderer indicator2;
    
    private float time;
    private void Start()
    {
        initialPosition = transform.position;



        

    }

    private void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
//        indicator1 = GameObject.Find("indicator1").GetComponent<SpriteRenderer>();
 //       indicator2 = GameObject.Find("indicator2").GetComponent<SpriteRenderer>();
        
       // indicator1.enabled = false;
       // indicator2.enabled = false;
       
       
       if (time == 0.1 )
       {
           Destroy(GameObject.Find("Spawner"));
       }
    }

    private void OnMouseDown()
    {
        if (!isDragging)
        {
            
            isDragging = true;
   //         indicator1 = GameObject.Find("indicator1").GetComponent<SpriteRenderer>();
   //         indicator2 = GameObject.Find("indicator2").GetComponent<SpriteRenderer>();
        
       //     indicator1.enabled = true;
       //     indicator2.enabled = true; 
            
        }
        
        
    }

    private void OnMouseDrag()
    {
        if (isDragging)
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(mousePosition.x, mousePosition.y, transform.position.z);
        }
    }

    private void OnMouseUp()
    {
        if (isDragging)
        {
            isDragging = false;
            
            
            // Check if the object is within the drop area
            StartCoroutine(WaitForFunction());
     //       indicator1 = GameObject.Find("indicator1").GetComponent<SpriteRenderer>();
     //       indicator2 = GameObject.Find("indicator2").GetComponent<SpriteRenderer>();
        
          //  indicator1.enabled = false;
          //  indicator2.enabled = false; 
            
        }
        
        
    }

    IEnumerator WaitForFunction()
    {
        yield return new WaitForSeconds(0.5f);
        Debug.Log("move"); 
        //transform.position = initialPosition;
        Destroy(this.gameObject);
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("cage"))
        {
            
            
           // ScoreIndicator indicator = Instantiate(damageText, transform.position, Quaternion.identity).GetComponent<ScoreIndicator>();
           // indicator.SetDamageText(20);
            stage01 = GameObject.Find("GameManager").GetComponent<GameManagerStage01>(); 
            stage01.AnimalNumber = animalnumber;
            stage01.LockAnimal();
            Destroy(this.gameObject);
            Debug.Log("Cage add score");
            stage01.AnimalNumber = 0;
            // indicator1 = GameObject.Find("indicator1").GetComponent<SpriteRenderer>();
            //indicator2 = GameObject.Find("indicator2").GetComponent<SpriteRenderer>();

            // indicator1.enabled = false;
            //indicator2.enabled = false;
        }
       
    }
    
    
}
