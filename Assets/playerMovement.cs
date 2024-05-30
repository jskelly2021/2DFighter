using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody2D body;
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Horizontal Movement
        float xInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2 (xInput * speed, body.velocity.y);


    }
}
