using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float moveForce = 50f;
    public float maxSpeed = 2f;

    private float h;
    private bool facingRight;
    private Rigidbody2D rb2d;

	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        if (Random.Range(0, 2) > 0)
        {
            h = 1;
            facingRight = true;
        }
        else
        {
            h = -1;
            facingRight = false;
        }
	}
	
	void Update () {
		
	}

    void FixedUpdate() {
        if (h * rb2d.velocity.x < maxSpeed) rb2d.AddForce(Vector2.right * h * moveForce);
        if (Mathf.Abs(rb2d.velocity.x) > maxSpeed) rb2d.velocity = new Vector2(Mathf.Sign(rb2d.velocity.x) * maxSpeed, rb2d.velocity.y);
    }

    public void Flip()
    {
        h *= -1;
        facingRight = !facingRight;
        //transform.Translate(Vector3.left * Time.deltaTime);

        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
}
