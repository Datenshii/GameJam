using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rayolul : MonoBehaviour
{
    private float lightningDuration = 0.5f;

    void Start()
    {
        Destroy(gameObject, lightningDuration);
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
