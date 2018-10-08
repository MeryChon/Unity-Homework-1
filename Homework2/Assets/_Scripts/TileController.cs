using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileController : MonoBehaviour {

    private Color originalColor;

	// Use this for initialization
	void Start () {
        originalColor = GetComponent<Renderer>().material.color;

    }
	
    void OnCollisionEnter(Collision collision)
    {
        GameObject collider = collision.gameObject;
        GetComponent<Renderer>().material.color = collider.GetComponent<Renderer>().material.color;

    }

    void OnCollisionExit()
    {
        GetComponent<Renderer>().material.color = originalColor;
    }
}
