﻿using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	// Use this for initialization
	void Start () {
        this.GetComponent<Rigidbody>().velocity = new Vector3(-10.0f, 9.0f, 0.0f);
	}
	
    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
