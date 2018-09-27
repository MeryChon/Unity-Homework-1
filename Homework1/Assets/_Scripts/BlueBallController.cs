using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBallController : MonoBehaviour
{
    public float x;
    public float y;
    public float z;

    private void Awake()
    {
        //გამოიძახება მხოლოდ ერთხელ, სცენის ჩატვირთვამდე
        this.x = 0f;
        this.y = 4f;
        this.z = 0f;
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
    }
}
