using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador1 : MonoBehaviour {
    public float speed = 10.0f;
    private Rigidbody2D rb;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            var vel = rb.velocity;
            vel.y = speed;
            rb.velocity = vel;
        }
        if (Input.GetKey(KeyCode.S))
        {
            var vel = rb.velocity;
            vel.y = -speed;
            rb.velocity = vel;
        }
        else if (!Input.anyKey)
        {
            var vel = rb.velocity;
            vel.y = 0.0f;
            rb.velocity = vel;

        }
        var reset = rb.velocity;
        reset.x = 0;
        rb.velocity = reset;
    }
}
