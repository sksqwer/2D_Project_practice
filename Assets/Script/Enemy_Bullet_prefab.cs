using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Bullet_prefab : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    int velocity = 1500;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        Destroy(gameObject, 10.0f);
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    private void move()
    {
        Vector3 pos = rigidBody.transform.position;
        pos = new Vector3(pos.x - velocity * Time.deltaTime, pos.y, pos.z);

        rigidBody.MovePosition(pos);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("trigger");
        if (collision.gameObject.tag == "Player")
        {
            GameObject.Find("Player2D").GetComponent<Player_2D>().PlaySound("");
            collision.gameObject.GetComponent<Player_2D>().HP -= 10;
            Destroy(gameObject);
        }
    }
    
}
