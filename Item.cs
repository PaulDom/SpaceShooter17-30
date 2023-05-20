using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public GameObject prefabExplosion;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Player playerScript = collision.GetComponent<Player>();
            playerScript.point++;

            GameObject effect = Instantiate(prefabExplosion, transform.position, Quaternion.identity);
            Destroy(effect, 3f);

            Destroy(gameObject);
        }
    }
}
