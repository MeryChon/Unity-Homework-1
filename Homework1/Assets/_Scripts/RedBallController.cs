using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBallController : MonoBehaviour
{

    public Rigidbody _rigidBody;
    public int forceY = 430;

    private int numCollisions;
    private float x, y, z;


    private void Awake()
    {
        //გამოიძახება მხოლოდ ერთხელ, სცენის ჩატვირთვამდე
        this.x = -4f;
        this.y = 4f;
        this.z = 0f;

        this.numCollisions = 0;
    }

    private void Start()
    {
        //გამოიძახება მხოლოდ ერთხელ, სცენის ჩატვირთვის შემდეგ
    }

    private void Update()
    {
        //გამოიძახება ყოველ ფრეიმზე
    }

    private void OnEnable()
    {
        //გამოიძახება ყოველ ჯერზე როდესაც ობიექტი ხდება აქტიური (ინსპექტორში enable ღილაკის მონიშვნით)
        transform.position = new Vector3(x, y, z);
    }

    private void OnDisable()
    {
        //გამოიძახება ყოველ ჯერზე როდესაც ობიექტი ხდება არა აქტიური (ინსპექტორში enable ღილაკის მონიშვნით)
        this._rigidBody.velocity = new Vector3(0,0,0);
    }

    void OnCollisionEnter()
    {
        this._rigidBody.AddForce(0, this.forceY, 0);
        Debug.Log(++this.numCollisions);
    }
}
