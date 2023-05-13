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

            Instantiate(prefabCreate, postitionSpawn, Quaternion.identity);

            timePassed = 0;
        }    
    }
}
