using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    public int score ;
    //Text score;

    //void Start()
    //{
    //    score = GetComponent<Text>();
    //}

    //void Update()
    //{
    //    score.text = "Score" + scoreValue;
    // }

    void Start()
    {
        score = 0;
        UpdateHUD();
    }

    public void ScoreCount(int count)
    {
        score += count;
        UpdateHUD();
    }

    public void UpdateHUD()
    {
        GameObject.Find("Canvas-HUD").GetComponent<HUDManager>().SetPlayersScore(score);

    }

}
