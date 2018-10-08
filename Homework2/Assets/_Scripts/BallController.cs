using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {
    private Rigidbody _rigidBody;
    public float speed;

	// Use this for initialization
	void Start () {
        this._rigidBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate()
    {
        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");

        Vector3 force = new Vector3(hAxis * speed, 0.0f, vAxis * speed);
        this._rigidBody.AddForce(force);

        //if (hAxis <= 0.0001f)
        //{
        //    this._rigidBody.velocity = new Vector3(0.0f, 0.0f, _rigidBody.velocity.z);
        //}
        //if (vAxis <= 0.0001f)
        //{
        //    this._rigidBody.velocity = new Vector3(_rigidBody.velocity.x, 0.0f, 0.0f);
        //}
    }

    void OnCollisionEnter(Collision collision)
    {
     
        GameObject collider = collision.gameObject;
        if(collider.CompareTag("ColoredTile"))
        {
            Color color = collider.GetComponent<Renderer>().material.color;
            Debug.Log(color);
            GetComponent<Renderer>().material.SetColor("_Color", color);
        }
    }
}
