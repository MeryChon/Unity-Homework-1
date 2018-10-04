using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {
    private Rigidbody _rigidBody;

	// Use this for initialization
	void Start () {
        this._rigidBody = GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate()
    {

    }
}
