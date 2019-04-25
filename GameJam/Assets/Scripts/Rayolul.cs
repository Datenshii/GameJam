using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rayolul : MonoBehaviour {

	void Start () {
		
	}
	
	void Update () {
		
	}


    void OnTriggerEnter2D(Collider2D collision)
    {
        Enemy enemy = collision.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.SmiteHit();
        }
        Invoke("Destroy(gameObject)", 1);
    }
}
