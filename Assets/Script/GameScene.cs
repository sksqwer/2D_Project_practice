using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScene : MonoBehaviour
{
    Player_2D player;
    public GameObject endImage;
    bool end_flag = false;
    static int n = 0;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player2D").GetComponent<Player_2D>();
        Gamemanager_2D g = Gamemanager_2D.Instance;
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        end();
    }

    void end()
    {
        if (n > 100)
        {
            Time.timeScale = 0;
        }
        if (player.HP <= 0)
        {
            endImage.SetActive(true);
            n++;
        }

    }
}
