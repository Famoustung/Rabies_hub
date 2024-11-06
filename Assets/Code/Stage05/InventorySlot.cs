using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        // ตรวจสอบว่าช่องว่างว่างหรือไม่
        if (transform.childCount == 0)
        {
            Debug.Log("childCount");
            // รับ GameObject ที่ถูกวางลง
            GameObject dropped = eventData.pointerDrag;

            // รับ Component DraggabInBox ของ GameObject ที่ถูกวางลง
            DraggabInBox draggabInBox = dropped.GetComponent<DraggabInBox>();
        }
    }
}
