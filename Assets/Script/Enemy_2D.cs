using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_2D : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    float maxSpeed = 500.0f;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        Destroy(gameObject, 20.0f);
        
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    private void move()
    {
        Vector3 pos = rigidBody.transform.position;
        pos = new Vector3(pos.x + -1 * maxSpeed * Time.deltaTime, pos.y, pos.z);

        rigidBody.MovePosition(pos);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Player_2D>().HP = 0;
        }
    }
}
