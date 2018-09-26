using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBallController : MonoBehaviour
{
    private void Awake()
    {
        //გამოიძახება მხოლოდ ერთხელ, სცენის ჩატვირთვამდე
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
    }

    private void OnDisable()
    {
        //გამოიძახება ყოველ ჯერზე როდესაც ობიექტი ხდება არა აქტიური (ინსპექტორში enable ღილაკის მონიშვნით)
    }
}
