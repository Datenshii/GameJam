using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ometeorlul : MonoBehaviour
{
    public Omegasplosionlul omegasplosionlul;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Enemy enemy = collision.GetComponent<Enemy>();
        Suelo suelo = collision.GetComponent<Suelo>();
        if (enemy != null || suelo != null)
        {
            Instantiate(omegasplosionlul, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
