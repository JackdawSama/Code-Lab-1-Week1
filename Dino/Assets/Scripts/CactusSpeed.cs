using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusSpeed : MonoBehaviour
{
    public float moveSpeed = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(Vector2.down * moveSpeed * Time.deltaTime); 
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x == -9.25)
        {
            Destroy(gameObject);
        }
    }
}
