using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Omegasplosionlul : MonoBehaviour
{
    private float explosionDuration = 0.3f;

    void Start()
    {
        Destroy(gameObject, explosionDuration);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Enemy enemy = collision.GetComponent<Enemy>();

        if (enemy != null)
        {
            enemy.MeteorHit();
        }
    }
}
