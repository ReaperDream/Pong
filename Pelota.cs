using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelota : MonoBehaviour {
    private Rigidbody2D rb;
    private Vector2 vel;
    

    void GoBall()
    {
        float rand = Random.Range(0.0f, 2.0f);
        if (rand < 1.0f)
        {
            rb.AddForce(new Vector2(20.0f, -15.0f));
        }
        else
        {
            rb.AddForce(new Vector2(-20.0f, -15.0f));
        }
    }
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        Invoke("GoBall", 2.0f);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.collider.CompareTag("Palo"))
        {
            vel.x = rb.velocity.x;
            vel.y = (rb.velocity.y / 2.0f) + (coll.collider.attachedRigidbody.velocity.y / 3.0f);
            rb.velocity = vel;
        }
        if(coll.collider.CompareTag("Derecha"))
        {
            BallReset();
        }
        if (coll.collider.CompareTag("Izquierda"))
        {
            BallReset();
        }
    }
    void BallReset()
    {
        vel.y = 0;
        vel.x = 0;
        rb.velocity = vel;
        gameObject.transform.position = new Vector2(0, 0);
        StartCoroutine(Reiniciar());

    }
    IEnumerator Reiniciar()
    {
        yield return new WaitForSeconds(3);
        GoBall();
    }

}
