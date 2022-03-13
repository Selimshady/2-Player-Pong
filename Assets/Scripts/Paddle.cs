using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    public bool isPlayer1;
    public Vector3 startPosition;

    private float movement;


    private void Awake() 
    {
        rb = this.GetComponent<Rigidbody2D>();
    }
    
    private void Start() 
    {
        startPosition = transform.position;    
    }

    // Update is called once per frame
    void Update()
    {
        if(isPlayer1)
        {
            movement = Input.GetAxis("Vertical");
        }
        else
        {
            movement = Input.GetAxis("Vertical2");
        }    
    }

    private void FixedUpdate() 
    {
        rb.velocity = new Vector2(rb.velocity.x, movement * speed);
    }

    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
    }
}
