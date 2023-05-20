using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    public GameObject prefabExplosionPlayer;
    public GameObject prefabExplosionObstacle;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            GameObject effectPlayer = Instantiate(prefabExplosionPlayer, collision.transform.position, Quaternion.identity);
            Destroy(effectPlayer, 3f);

            GameObject effectObstacle = Instantiate(prefabExplosionObstacle, transform.position, Quaternion.identity);
            Destroy(effectObstacle, 3f);

            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
