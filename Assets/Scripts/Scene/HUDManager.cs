using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDManager : MonoBehaviour
{
    public Text playerHealth;
    public Text playerScore;
    public Text playerHeal;
    public Text playerSouls;
    

    public void SetPlayersHealth(int health)
    {
        playerHealth.text = $"HEALTH: {health}";
    }

    public void SetPlayersScore(int coins)
    {
        playerScore.text = $"SCORE: {coins}";
    }


    public void SetPlayersSouls(int souls)
    {
        playerSouls.text = $"SOULS: {souls}";
    }

}
