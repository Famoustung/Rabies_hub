using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class GrabController : MonoBehaviour
{
    private Rigidbody2D rb;
    public bool IsCarrying = false;
    public Transform[] carriedObject;
    public Transform player;
    float rayDist;
    public Animator _animator;
    public SpriteRenderer sprite;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    } 
    void Update()
    {
        


        Vector3 pos = transform.position;

        if (Input.GetKey("w")) 
        {
            pos.y += 4 * Time.deltaTime;
            _animator.SetFloat("Vertical",1);
            
        }
        if (Input.GetKey("s")) 
        {
            pos.y -= 4 * Time.deltaTime;
            _animator.SetFloat("Vertical",-1);
            
        }
        if (Input.GetKey("d")) 
        {
            pos.x += 4 * Time.deltaTime;
            sprite.flipX = false; 
            _animator.SetFloat("Horizontal",1);
           
        }
        if (Input.GetKey("a")) 
        {
            pos.x -= 4 * Time.deltaTime;
            sprite.flipX = true; 
            _animator.SetFloat("Horizontal",-1);
            
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            pos.y += 4 * Time.deltaTime;
            _animator.SetFloat("Vertical", 1);

        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            pos.y -= 4 * Time.deltaTime;
            _animator.SetFloat("Vertical", -1);

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            pos.x += 4 * Time.deltaTime;
            sprite.flipX = false;
            _animator.SetFloat("Horizontal", 1);

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            pos.x -= 4 * Time.deltaTime;
            sprite.flipX = true;
            _animator.SetFloat("Horizontal", -1);

        }

        transform.position = pos;
     
            
    }
    
   

    public void PickUpObject()
    {
        carriedObject[0].gameObject.transform.parent = player; 
        carriedObject[1].gameObject.transform.parent = player;
        // ตรวจสอบว่ามี NPC อยู่ใกล้หรือไม่
        SoundManager.Instance.PlaySound(SoundType.catchs ,false);
        RaycastHit2D grabcheck =
            Physics2D.Raycast(carriedObject[0].position, Vector2.right * transform.localScale, rayDist);
            
            if (grabcheck.collider != null && grabcheck.collider.tag == "GrabObject")
            {
                _animator.SetFloat("Pick",1);
                // ยก NPC ขึ้นมา
                grabcheck.collider.gameObject.transform.parent = carriedObject[0];
                grabcheck.collider.gameObject.transform.position = carriedObject[0].position;
                grabcheck.collider.gameObject.GetComponent<SpriteRenderer>().enabled = false; 
                grabcheck.collider.gameObject.GetComponent<NPCController>().canWalk = false;
                IsCarrying = true;

                
            }
            RaycastHit2D grabcheck2 =
                Physics2D.Raycast(carriedObject[1].position, Vector2.left * transform.localScale, rayDist);
            
            if (grabcheck2.collider != null && grabcheck2.collider.tag == "GrabObject")
            {
                _animator.SetFloat("Pick",1);
                // ยก NPC ขึ้นมา
                grabcheck2.collider.gameObject.transform.parent = carriedObject[1];
                grabcheck2.collider.gameObject.transform.position = carriedObject[1].position;
                grabcheck2.collider.gameObject.GetComponent<SpriteRenderer>().enabled = false; 
                grabcheck2.collider.gameObject.GetComponent<NPCController>().canWalk = false;
                IsCarrying = true;

                
            } 
    }

    public void DropObject()
    {
        

        RaycastHit2D grabcheck = Physics2D.Raycast(carriedObject[0].position, Vector2.right * transform.localScale, rayDist);
            
        if ( grabcheck.collider != null && grabcheck.collider.tag == "GrabObject")
        {
            grabcheck.collider.gameObject.GetComponent<SpriteRenderer>().enabled = true; 
            _animator.SetFloat("Pick",0); 
            grabcheck.collider.gameObject.transform.parent = null;
            IsCarrying = false;
            
        }
        
        RaycastHit2D grabcheck2 = Physics2D.Raycast(carriedObject[1].position, Vector2.left * transform.localScale, rayDist);
            
        if (grabcheck2.collider != null && grabcheck2.collider.tag == "GrabObject")
        {
            grabcheck2.collider.gameObject.GetComponent<SpriteRenderer>().enabled = true; 
            _animator.SetFloat("Pick",0); 
            grabcheck2.collider.gameObject.transform.parent = null;
            IsCarrying = false;
            
        } 
       
    }
    
}
