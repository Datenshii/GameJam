using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float moveForce = 50f;
    public float maxSpeed = 2f;
    public float h;
    public LevelManager levelManager;
    public int points;

    private float flipCd;
    private Rigidbody2D rb2d;

	void Start () {
        rb2d = GetComponent<Rigidbody2D>();

        h = 1f;
        flipCd = Random.Range(1f, 5f);

        if (Random.Range(0, 2) == 0)
        {
            Flip();
        }

        levelManager = FindObjectOfType<LevelManager>();

        points = 3;

	}
	
	void Update () {
		
	}

    void FixedUpdate() {
        flipCd -= Time.deltaTime;

        if(flipCd <= 0) Flip();

        if (h * rb2d.velocity.x < maxSpeed) rb2d.AddForce(Vector2.right * h * moveForce);
        if (Mathf.Abs(rb2d.velocity.x) > maxSpeed) rb2d.velocity = new Vector2(Mathf.Sign(rb2d.velocity.x) * maxSpeed, rb2d.velocity.y);

    }

    public void SmiteHit()
    {
        levelManager.scorePoints += points;
        Destroy(gameObject);
    }

    public void Flip()
    {
        h *= -1;
        flipCd = Random.Range(1f, 5f);

        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
}
