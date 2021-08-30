using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet1 : MonoBehaviour
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
        pos = new Vector3(pos.x + velocity * Time.deltaTime, pos.y, pos.z);

        rigidBody.MovePosition(pos);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Gamemanager_2D.Instance.score += 100;
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
