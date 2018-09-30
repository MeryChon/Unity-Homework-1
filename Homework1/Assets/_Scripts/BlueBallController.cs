using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBallController : MonoBehaviour
{

    public Rigidbody _rigidBody;
    public int forceY;

    private float x, y, z;
    private bool isOnGround;
    private string jumpKeyName = "space";


    private void Awake()
    {
        //გამოიძახება მხოლოდ ერთხელ, სცენის ჩატვირთვამდე
        this.x = 0f;
        this.y = 4f;
        this.z = 0f;

        this.isOnGround = false;

    }

    private void Start()
    {
        //გამოიძახება მხოლოდ ერთხელ, სცენის ჩატვირთვის შემდეგ
    }

    private void Update()
    {
        //გამოიძახება ყოველ ფრეიმზე
        if (Input.GetKey(this.jumpKeyName))
        {
            if(this.isOnGround)
            {
                this._rigidBody.AddForce(0, this.forceY, 0);
                this.isOnGround = false;

            }
        }
    }

    private void OnEnable()
    {
        //გამოიძახება ყოველ ჯერზე როდესაც ობიექტი ხდება აქტიური (ინსპექტორში enable ღილაკის მონიშვნით)
        transform.position = new Vector3(x, y, z);
    }

    private void OnDisable()
    {
        //გამოიძახება ყოველ ჯერზე როდესაც ობიექტი ხდება არა აქტიური (ინსპექტორში enable ღილაკის მონიშვნით)
        this._rigidBody.velocity = new Vector3(0, 0, 0);
    }

    void OnCollisionEnter()
    {
        this.isOnGround = true;
    }

}
