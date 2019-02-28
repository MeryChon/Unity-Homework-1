using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {
    [SerializeField]
    private Vector2 _velocity;
    private Rigidbody2D rb;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = _velocity;
	}
	
	// Update is called once per frame
	void Update () {
        rb.velocity = _velocity;
    }
}
