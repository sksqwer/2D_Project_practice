using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefaultUI : MonoBehaviour
{
    public Text txtScore;
    public Image HpBar;
    // Start is called before the first frame update
    void Start()
    {
        ShowScore(100);
        ShowHpBar(50);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowScore(int score)
    {
        txtScore.text = "Score : <color=#0000ff>" + score.ToString() + "</color>";
    }

    public void ShowHpBar(int HP)
    {
        HpBar.fillAmount = (float)HP / (float)100;
    }
}
