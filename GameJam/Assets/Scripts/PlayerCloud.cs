using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCloud : MonoBehaviour {

    private float h = 5f;

    void Start()
    {

    }

    void Update()
    {
        if (transform.position.x >= 8 || transform.position.x <= -8)
        {
            Flip();
        }
        transform.Translate(Time.deltaTime * h, 0, 0);
    }

    public void Flip()
    {
        h *= -1;
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }


}
