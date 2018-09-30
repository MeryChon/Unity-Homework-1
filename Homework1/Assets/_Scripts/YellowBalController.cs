using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowBalController : MonoBehaviour
{

    public Rigidbody _rigidBody;

    private float x, y, z, startTime, speed, totalDistance;
    private Vector3 startPosition, endPosition;


    private void Awake()
    {
        //გამოიძახება მხოლოდ ერთხელ, სცენის ჩატვირთვამდე
        this.x = 4f;
        this.y = 4f;
        this.z = 0f;
    }

    private void Start()
    {
        //გამოიძახება მხოლოდ ერთხელ, სცენის ჩატვირთვის შემდეგ
        this.startTime = Time.time;
        this.speed = 20f;
        this.totalDistance = 4f;
        this.startPosition = new Vector3(this.x, 0, this.z);
        this.endPosition = new Vector3(this.x, this.y, this.z);
    }

    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("before setting " + this._rigidBody.velocity);
            this._rigidBody.velocity = new Vector3(0, 0, 0);
            Debug.Log("after setting " + this._rigidBody.velocity);
        }

        if (Input.GetMouseButtonDown(0))
        {
            this.startPosition = transform.position;
            this.startTime = Time.time;
            
        }

        //გამოიძახება ყოველ ფრეიმზე
        if (Input.GetMouseButton(0))  //მარცხენა  ღილაკზე დაჭერისას უბრუნდება საწყის პოზიციას და რჩება იქ, სანამ ღილაკს არ ავუშვებთ ხელს
        {
            //Debug.Log(this.startPosition);
            float distanceCovered = (Time.time - this.startTime) * this.speed;
            //Debug.Log(distanceCovered);
            float coveredFraction = distanceCovered / this.totalDistance;
            transform.position = Vector3.Lerp(this.startPosition, this.endPosition, coveredFraction);
            //transform.position = new Vector3(this.x, this.y, this.z);
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
    }

}
