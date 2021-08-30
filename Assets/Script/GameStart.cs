using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    Sound_Object sound;
    GameObject sound_object;
    // Start is called before the first frame update
    void Start()
    {
        sound_object = GameObject.Find("SoundObj"); 
        sound = GameObject.Find("SoundObj").GetComponent<Sound_Object>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GameStart_On()
    {
        Time.timeScale = 1;
        gameObject.SetActive(false);
        sound_object.GetComponent<Sound_Object>().changeClip(1);
        sound.GetComponent<AudioSource>().Play();
        sound.GetComponent<AudioSource>().loop = false;
    }
}
