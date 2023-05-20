using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public GameObject prefabExplosion;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Obstacle")
        {
            Destroy(collision.gameObject);

            GameObject effect = Instantiate(prefabExplosion, collision.transform.position, Quaternion.identity);
            Destroy(effect, 3f);
            Destroy(gameObject);
        }
    }
}
