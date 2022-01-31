using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusSpawner : MonoBehaviour
{
    public GameObject cactus;
    Vector2 spawnLocation;
    float spawnDelay;

    // Start is called before the first frame update
    void Start()
    {
        spawnLocation = GameObject.Find("Spawner").transform.position;
        Spawner();
    }

    void Update()
    {

    }

    public void Spawner()
    {
        spawnDelay = Random.Range(1.0f, 2.0f);                                          //randomises the delay inbetween spawns
        Instantiate(cactus);                                                            //creates an object
        cactus.transform.position = new Vector2(spawnLocation.x, spawnLocation.y);      //sets the created object's transform

        Invoke("Spawner", spawnDelay);                                                  //function calls itself to repeat spawing of object
    }
}
