﻿using System.Collections;
using UnityEngine;

namespace DialogueSystem
{
    public class DialogueHolder : MonoBehaviour
    {
        private int numberChild,count;

        private void Awake()
        {
            StartCoroutine(dialogueSequence());
        }

        private void Update()
        {
            numberChild = transform.childCount;
            Debug.Log(numberChild);
        }

        private IEnumerator dialogueSequence()
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                
                Deactivate();
                transform.GetChild(i).gameObject.SetActive(true);
                
                yield return new WaitUntil(() => transform.GetChild(i).GetComponent<DialogueLine>().finished);
            }


            //gameObject.SetActive(false);
        }

        private void Deactivate()
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                
                    transform.GetChild(i).gameObject.SetActive(false);
                

                
            }
        }
    }
}

