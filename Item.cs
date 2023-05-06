using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Player playerScript = collision.GetComponent<Player>();
            playerScript.point++;
            Destroy(gameObject);
        }
    }
}
