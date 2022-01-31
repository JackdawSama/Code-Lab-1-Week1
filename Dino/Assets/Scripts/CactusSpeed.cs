using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusSpeed : MonoBehaviour
{
    public float moveSpeed = 2.0f;
    Vector2 newPos;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        newPos = transform.position;
        newPos.x -= moveSpeed * Time.deltaTime;                 //makes the object move along the negative x-axis
        transform.position = newPos;


        if(transform.position.x <= -9.25)                       //checks the position of the object and if out of bounds deletes it
        {
            Destroy(gameObject);                                //deletes the object when it goes out of bounds
        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "Player")                              //checks if the name of the gameobject is Player
        {
            Debug.Log("Player");                                //debug statement to check if the collision works
            Destroy(other.gameObject);                          //on collision Player gets deleted
        }
    }
    }
