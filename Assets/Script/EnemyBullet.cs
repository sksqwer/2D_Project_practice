using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public GameObject bullet_Prefab;
    public float interval = 2.0f;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        while(true)
        {

            Instantiate(
              bullet_Prefab,
              transform.position,
              transform.rotation);
            yield return new WaitForSeconds(interval);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }

}
