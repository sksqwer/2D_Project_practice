using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_2D : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    float maxSpeed = 2000.0f;

    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        //anim.speed = 2;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Move_2D(x, y);
    }

    private void Move_2D(float x, float y)
    {
        Vector3 pos = rigidBody.transform.position;
        pos = new Vector3(pos.x + x * maxSpeed * Time.deltaTime, pos.y + y * maxSpeed * Time.deltaTime, pos.z);

        rigidBody.MovePosition(pos);

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

    }
}
