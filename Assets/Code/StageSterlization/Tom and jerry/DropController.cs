using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DropController : MonoBehaviour
{
   public int  score;
   private bool IsDone = false;
   private int amountPet;
   public TextMeshProUGUI amountText;
   public GameObject player;
   public GameObject Win;
   public GameObject dogStillHere;
    public bool Isplay = false;
   private void Update()
   {
      if (amountPet == 5)
      {
            if (!Isplay)
            {
                SoundManager.Instance.PlaySound(SoundType.victory, false);
                Isplay = true;
            }
            Win.SetActive(true);
         Debug.Log("End");
      } 
      
      amountText.text = "จับได้แล้ว : " + amountPet + "/ 5 ตัว";
   }


   

   private void OnTriggerEnter2D(Collider2D other)
   {
      
      if (other.gameObject.CompareTag("GrabObject"))
      {
         amountPet++;
         Debug.Log(amountPet);
         player.GetComponent<GrabController>().DropObject();
         other.GetComponent<CapsuleCollider2D>().enabled = false;
         other.gameObject.SetActive(false);
            SoundManager.Instance.PlaySound(SoundType.correct, false);
        }
   }

   
}
