using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpSpeed;
    // public float gravity;

    Vector2 newPos;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
    {
        rb.AddForce(Vector2.up * jumpSpeed, ForceMode2D.Impulse);           //adds a jump force to the object and smoothes it using ForceMode2D I guess.
    }
        /*got the above code for jump force from https://gamedevbeginner.com/how-to-jump-in-unity-with-or-without-physics/#jump_unity and I have to go through the documentation to 
        understand what ForceMode2D and AddForce in general do*/
    }


}
