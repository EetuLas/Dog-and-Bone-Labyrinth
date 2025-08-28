using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerScript : MonoBehaviour
{
    private bool dragging = false;
    private Vector3 offset;
    private Vector3 targetPos;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0f;
        rb.freezeRotation = true;
    }

    void Update()
    {
        if (dragging)
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = -Camera.main.transform.position.z;
            targetPos = Camera.main.ScreenToWorldPoint(mousePos) + offset;
            targetPos.z = 0f;
        }
    }

    void FixedUpdate()
    {
        if (dragging)
        {
            // Move the Rigidbody smoothly while respecting collisions
            rb.MovePosition(targetPos);
        }
    }

    private void OnMouseDown()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = -Camera.main.transform.position.z;
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
        Cursor.visible = false;
        dragging = true;
    }

    private void OnMouseUp()
    {
        dragging = false;
        Cursor.visible = true;    
    }
}
