using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MaskMovement : MonoBehaviour
{
    private Vector2 mousePos;
    public float moveSpeed = 1f ;
    void Update()
    {
        mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        transform.position = Vector2.MoveTowards(transform.position, mousePos, moveSpeed);
    }
}
