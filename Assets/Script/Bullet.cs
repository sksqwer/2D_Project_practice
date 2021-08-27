using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject bullet_Prefab;

    public AudioClip shotClip;
    private AudioSource Shot_Source;
    // Start is called before the first frame update
    void Start()
    {
        Shot_Source = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
           // if (Shot_Source.isPlaying) return;

            PlaySound("attack");

            Instantiate(
              bullet_Prefab,
              transform.position,
              transform.rotation);


        }
    }

    void PlaySound(string clip)
    {
        Shot_Source.PlayOneShot(shotClip);
    }
}
