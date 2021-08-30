using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager_2D : MonoBehaviour
{
    private static Gamemanager_2D sInstance;

    public static Gamemanager_2D Instance
    {
        get
        {
            if (sInstance == null)
            {
                GameObject newGameObj = new GameObject("_GameManager");
                sInstance = newGameObj.AddComponent<Gamemanager_2D>();
            }
            return sInstance;
        }
    }

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);   
    }

    public int score = 100;

    //variable
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
