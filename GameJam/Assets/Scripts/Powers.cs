using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powers : MonoBehaviour {

    public Transform SmitePoint;
    public GameObject SmiteObject;

    private float powerCd;


	// Use this for initialization
	void Start () {
        powerCd = 1f;
	}
	
	// Update is called once per frame
	void Update ()
    {
        powerCd -= Time.deltaTime;
        if (Input.GetButtonDown("Fire1") && powerCd <= 0)
        {
            Smite();
            powerCd = 1f;
        }
    }

    void FixedUpdate()
    {
        
    }

    void Smite ()
    {
        Instantiate(SmiteObject, SmitePoint.position, SmitePoint.rotation);
    }
}
