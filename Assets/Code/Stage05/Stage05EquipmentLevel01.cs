using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Stage05EquipmentLevel01 : MonoBehaviour, IDropHandler
{
    public GameObject clean;
    public Image oldImage;
    public Sprite sp1/*, sp2*/;
    [SerializeField] GameObject Box;
    [SerializeField] private String A;
    [SerializeField] private String B;
    public ScoreManager scoreManager;
    private bool stepB = false;
    
   
    private void Start()
    {
        scoreManager = ScoreManager.Instance;
    }

    private void Update()
    {
        
    }

    public void OnDrop(PointerEventData eventData)
    {
        GameObject dropped = eventData.pointerDrag;
        DraggabInBox draggabInBox = dropped.GetComponent<DraggabInBox>();
        if (dropped.CompareTag(A) && stepB)
        {
            scoreManager.minusScoreLevel01();
            Debug.Log("A-Bug -1");
        }
        else if (dropped.CompareTag(A))
        {
            oldImage.sprite = sp1;
            scoreManager.plusScoreLevel01();
            Debug.Log("A-Ok +1");
            stepB = true;
        }
        else if (dropped.CompareTag(B) && !stepB)
        {
            scoreManager.minusScoreLevel01();
            Debug.Log("B-Bug -1");
        }
        else if (dropped.CompareTag(B) && stepB)
        {
            clean.SetActive(true);
            scoreManager.plusScoreLevel01();
            Debug.Log("B-Ok +1");
            Destroy(Box);
        }
    }
}
