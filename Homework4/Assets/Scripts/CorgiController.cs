using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorgiController : MonoBehaviour {

    [SerializeField]
    private float _velocity;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 oldPosition = transform.position;
        Vector2 shift; //= new Vector2(0, 0);
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position = oldPosition + new Vector2(-_velocity, 0);
        } else if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position = oldPosition + new Vector2(_velocity, 0);
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            //TODO: jump
        }

    }
}
