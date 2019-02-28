using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorgiController : MonoBehaviour {

    [SerializeField]
    private float _velocity = 0.1f;
    [SerializeField]
    private KeyCode _left;
    [SerializeField]
    private KeyCode _right;
    [SerializeField]
    private KeyCode _jump;
    [SerializeField]
    private KeyCode _shoot;
    [SerializeField]
    private float _force;
    [SerializeField]
    private GameObject leftBullet, rightBullet;
    [SerializeField]
    private bool isFacingRight;


    private Rigidbody2D _rigidBody;
    private Animator corgiAnimator;
    private bool isJumping;
    private Vector2 spawnPosition;
    private Transform firePosition;


    void Start () {
        _rigidBody = GetComponent<Rigidbody2D>();
        corgiAnimator = GetComponent<Animator>();
        isJumping = false;

        firePosition = transform.Find("FirePosition");
	}
	
	void Update () {
        Vector2 oldPosition = transform.position;
        Vector2 oldScale = transform.localScale;

        if(Input.GetKeyDown(KeyCode.A)&& (oldScale.x > 0) || (Input.GetKeyDown(KeyCode.D) && (oldScale.x < 0)))
        {
            transform.localScale = new Vector2((-1) * oldScale.x, oldScale.y);
        }

        if (Input.GetKey(_left))
        {
            corgiAnimator.SetBool("mustRun", true);
            transform.position = oldPosition + new Vector2(-_velocity, 0);
            isFacingRight = false;
            
        } else if (Input.GetKey(_right))
        {
            corgiAnimator.SetBool("mustRun", true);
            transform.position = oldPosition + new Vector2(_velocity, 0);
            isFacingRight = true;
        } else if(Input.GetKeyDown(_shoot))
        {
            Shoot();
        }
        if (Input.GetKey(_jump) && !isJumping)
        {
            isJumping = true;
            _rigidBody.AddForce(Vector2.up * _force);
            corgiAnimator.SetBool("mustJump", true);
        }

        if (Input.GetKeyUp(_right) || Input.GetKeyUp(_left))
        {
            corgiAnimator.SetBool("mustRun", false);
        }

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.CompareTag("wall"))
        {
            isJumping = false;
            corgiAnimator.SetBool("mustJump", false);
        }

    }


    void Shoot()
    {
        
        GameObject fireBurst = firePosition.gameObject;
        Debug.Log(fireBurst.activeSelf);
        fireBurst.SetActive(true);
        //GameObject bullet;
        //if(isFacingRight)
        //{
        //    bullet = leftBullet;
        //    //Instantiate(rightBullet, firePosition.position, Quaternion.identity);
        //} else
        //{
        //    bullet = rightBullet;
            
        //}
        //Instantiate(bullet, firePosition.position, Quaternion.identity);
        //if (bullet.transform.position.x >= fireBurst.transform.position.x + 0.2)
        //{
        //    fireBurst.SetActive(false);
        //}
        
    }

}
