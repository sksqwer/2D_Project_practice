using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ShowScore(Gamemanager_2D.Instance.score);
    }


    public void ShowScore(int score)
    {
        gameObject.GetComponent<Text>().text = "Score : <color=#0000ff>" + score.ToString() + "</color>";
    }
}
