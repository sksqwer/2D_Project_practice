using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet1 : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        Destroy(gameObject, 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    private void move()
    {
        Vector3 pos = rigidBody.transform.position;
        pos = new Vector3(pos.x + 1000 * Time.deltaTime, pos.y, pos.z);

        rigidBody.MovePosition(pos);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
