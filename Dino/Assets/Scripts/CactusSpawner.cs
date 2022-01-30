using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusSpawner : MonoBehaviour
{
    public GameObject cactus;
    public float spawnTimer;
    float spawnDelay;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawner", spawnTimer, spawnDelay);                     //invokes the function spawner at timed intervals
    }

    public void Spawner()
    {
        spawnDelay = Random.Range(0.5f, 1.0f);                                  //randomises the delay inbetween spawns
        Instantiate(cactus, transform.position, transform.rotation);           //creates an object at the said transform
    }
}
