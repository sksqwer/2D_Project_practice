using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefaultUI : MonoBehaviour
{
    public Text txtScore;
    public Image HpBar;
    Player_2D player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player2D").GetComponent<Player_2D>();
        ShowScore(Gamemanager_2D.Instance.score);
        ShowHpBar(player.HP / player.maxHP);
    }

    // Update is called once per frame
    void Update()
    {
        ShowScore(Gamemanager_2D.Instance.score);
        ShowHpBar(player.HP / player.maxHP);
    }

    public void ShowScore(int score)
    {
        txtScore.text = "Score : <color=#0000ff>" + score.ToString() + "</color>";
    }

    public void ShowHpBar(float HP)
    {
        HpBar.fillAmount = (float)HP;
    }
}
