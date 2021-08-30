using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_2D : MonoBehaviour
{
    public float maxHP = 100f;
    public float HP = 100f;
    private Rigidbody2D rigidBody;
    float maxSpeed = 2000.0f;
    public AudioClip shotClip;
    private AudioSource Shot_Source;

    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        Shot_Source = GetComponent<AudioSource>();
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

        if (pos.x < -569 || pos.x > 238 || pos.y > 213 || pos.y < -214)
            return;


        rigidBody.MovePosition(pos);

    }
    
    public void PlaySound(string clip)
    {
        Shot_Source.PlayOneShot(shotClip);
    }
}
