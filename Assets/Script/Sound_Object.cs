using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_Object : MonoBehaviour
{
    public AudioSource audio;
    public AudioClip[] clip = new AudioClip[5];

    // Start is called before the first frame update
    void Start()
    {
        audio = gameObject.GetComponent<AudioSource>();
        audio.loop = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeClip(int n)
    {
        audio.clip = clip[n];
    }
}
