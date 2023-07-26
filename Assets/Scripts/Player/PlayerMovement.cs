using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float speed = 7f;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    void Update()
    {
        Walk();    
    }

    void Walk() {
        if (Input.GetKey("w")) {
            rb.velocity = Vector2.up * speed;
        }
        else if (Input.GetKey("s")) {
            rb.velocity = Vector2.down * speed;
        }
        else if (Input.GetKey("a")) {
            rb.velocity = Vector2.left * speed;
        }
        else if (Input.GetKey("d")) {
            rb.velocity = Vector2.right * speed;
        } else {
            rb.velocity = Vector2.zero;
        }
    }
}
