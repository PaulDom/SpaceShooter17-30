using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int point = 0;
    public GameObject projectilePrefab;
    public float shootInterval = 0.5f;
    public float shootTimer = 0;

    void Update()
    {
        Move();

        shootTimer += Time.deltaTime;
        if (shootTimer >= shootInterval)
        {
            Shoot();
            shootTimer = 0;
        }
    }

    void Move()
    {
        Vector2 mousePos = Input.mousePosition;
        Vector2 realPos = Camera.main.ScreenToWorldPoint(mousePos);
        transform.position = realPos;
    }

    void Shoot()
    {
        Instantiate(projectilePrefab, transform.position, Quaternion.identity);
    }

}
