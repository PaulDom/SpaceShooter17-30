using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    void Update()
    {
        Move();
    }

    void Move()
    {
        Vector2 mousePos = Input.mousePosition;
        Vector2 realPos = Camera.main.ScreenToWorldPoint(mousePos);
        transform.position = realPos;
    }
}
