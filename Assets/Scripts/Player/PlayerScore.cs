using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    public int coins;
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
        coins = 0;

        //if (PlayerPrefs.HasKey("Coins"))
        //{
        //    coins = PlayerPrefs.GetInt("Coins");
        //}

        UpdateHUD();
    }

    public void ScoreCount(int count)
    {
        coins += count; 
        UpdateHUD();
    }

    public void UpdateHUD()
    {
        GameObject.Find("Canvas-HUD").GetComponent<HUDManager>().SetPlayersScore(coins);

    }

}
