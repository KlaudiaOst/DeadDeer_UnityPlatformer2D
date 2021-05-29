using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDManager : MonoBehaviour
{
    public Text playerHealth;
    public Text playerScore;
    public Text playerHeal;
    

    public void SetPlayersHealth(int health)
    {
        playerHealth.text = $"Health: {health}";
    }

    public void SetPlayersScore(int score)
    {
        playerScore.text = $"Score: {score}";
    }

    
}
