using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall : MonoBehaviour
{
    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.isKinematic = true; // Optional for non-physics interactions
        rb.bodyType = RigidbodyType2D.Static;
    }
}
