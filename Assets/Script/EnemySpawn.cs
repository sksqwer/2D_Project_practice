using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemy;
    public float interval = 1.0f;
    public float range = 3.0f;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (true)
        {
            transform.position = new Vector3(transform.position.x,
                Random.Range(-range, range),
                transform.position.z);


            Instantiate(enemy, transform.position, transform.rotation);
            yield return new WaitForSeconds(interval);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
