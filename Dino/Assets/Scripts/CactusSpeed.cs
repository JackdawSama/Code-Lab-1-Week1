using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            GameManager.lives--;                                //reduces the lives the player has in case of a collision
            Debug.Log(GameManager.lives);

            if(GameManager.lives < 1)                           //check is the player has 0 live and if true destroys the player object and shifts scene
            {
                Destroy(other.gameObject);                      //on collision Player gets deleted
                SceneManager.LoadScene("Replay");               //on the event of player object being destroyed the Replay scene is loaded
            }
        }
    }
    }
