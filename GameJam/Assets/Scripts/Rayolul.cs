using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rayolul : MonoBehaviour
{
    private float lightningDuration = 0.1f;

    void Start()
    {
        Destroy(gameObject, lightningDuration);
    }

    void Update()
    {

    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        Enemy enemy = collision.GetComponent<Enemy>();

        if (enemy != null)
        {
            enemy.SmiteHit();
        }
    }
}
