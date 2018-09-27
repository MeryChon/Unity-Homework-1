using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBallController : MonoBehaviour
{
    public float x = -4f;
    public float y = 4f;
    public float z = 0f;

    private int numCollisions;


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
        Debug.Log("sdklsdjlfksd");
    }

    private void Update()
    {
        //გამოიძახება ყოველ ფრეიმზე
    }

    private void OnEnable()
    {
        //გამოიძახება ყოველ ჯერზე როდესაც ობიექტი ხდება აქტიური (ინსპექტორში enable ღილაკის მონიშვნით)
        transform.position = new Vector3(x, y, z);
        Debug.Log(transform.position);
    }

    private void OnDisable()
    {
        //გამოიძახება ყოველ ჯერზე როდესაც ობიექტი ხდება არა აქტიური (ინსპექტორში enable ღილაკის მონიშვნით)
    }
}
