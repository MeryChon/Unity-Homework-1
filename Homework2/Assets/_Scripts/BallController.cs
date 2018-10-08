using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {
    public float speed;

    void FixedUpdate()
    {
        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");

        Vector3 oldPosition = transform.position;
        Vector3 change = new Vector3(hAxis * speed * Time.deltaTime, 0.0f, vAxis * speed * Time.deltaTime);
        transform.position = oldPosition + change;

    }

    void OnCollisionEnter(Collision collision)
    {
        GameObject collider = collision.gameObject;
        if(collider.CompareTag("ColoredTile"))
        {
            Color color = collider.GetComponent<Renderer>().material.color;
            GetComponent<Renderer>().material.SetColor("_Color", color);
        }
    }
}
