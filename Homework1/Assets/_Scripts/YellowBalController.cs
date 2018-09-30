using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowBalController : MonoBehaviour
{

    public Rigidbody _rigidBody;

    private Vector3 initialPosition;


    private void Awake()
    {
        //გამოიძახება მხოლოდ ერთხელ, სცენის ჩატვირთვამდე
        this.initialPosition = new Vector3(4f, 4f, 0f);
    }

    private void Start()
    {
        //გამოიძახება მხოლოდ ერთხელ, სცენის ჩატვირთვის შემდეგ
        
    }

    private void Update()
    {
        if (Input.GetMouseButtonUp(0) || transform.position == this.initialPosition)
        {
            this._rigidBody.velocity = new Vector3(0, 0, 0);
        }

        //გამოიძახება ყოველ ფრეიმზე
        if (Input.GetMouseButton(0))  //მარცხენა  ღილაკზე დაჭერისას უბრუნდება საწყის პოზიციას და რჩება იქ, სანამ ღილაკს არ ავუშვებთ ხელს
        {
            transform.position = initialPosition;
        }



    }

    private void OnEnable()
    {
        //გამოიძახება ყოველ ჯერზე როდესაც ობიექტი ხდება აქტიური (ინსპექტორში enable ღილაკის მონიშვნით)
        transform.position = this.initialPosition;
    }

    private void OnDisable()
    {
        //გამოიძახება ყოველ ჯერზე როდესაც ობიექტი ხდება არა აქტიური (ინსპექტორში enable ღილაკის მონიშვნით)
        this._rigidBody.velocity = new Vector3(0, 0, 0);
    }

}
