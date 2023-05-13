using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefabCreate;
    public Transform left;
    public Transform right;

    public float interval = 2;
    public float timePassed = 0;

    

    void Update()
    {
        timePassed += Time.deltaTime;
        if (timePassed >= interval)
        {
            Vector3 postitionSpawn = transform.position;
            float randomX = Random.Range(left.position.x, right.position.x);
            postitionSpawn.x = randomX;
            postitionSpawn.z = 0;

            GameObject objecCreate = Instantiate(prefabCreate, postitionSpawn, Quaternion.identity);
            Vector2 sizeObject = new Vector2(1, 1);
            float randomSize = Random.Range(0.5f, 1);
            sizeObject.x = randomSize;
            sizeObject.y = randomSize;

            objecCreate.transform.localScale = sizeObject;

            timePassed = 0;
        }    
    }
}
