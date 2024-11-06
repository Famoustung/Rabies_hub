using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DraggableItem : MonoBehaviour
{
    private bool isDragging;
    private Vector3 initialPosition;
    


    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnMouseDown()
    {
        if (!isDragging)
        {
            isDragging = true;
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
        }
    }
    
    IEnumerator WaitForFunction()
    {
        yield return new WaitForSeconds(0);
        Debug.Log("move"); 
        transform.position = initialPosition;
        
    }
}
