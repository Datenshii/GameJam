﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorDeath : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        Destroy(gameObject, 0.5f);
	}

}
