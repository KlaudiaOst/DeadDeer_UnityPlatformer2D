using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSouls : MonoBehaviour
{
    public int souls;
    void Start()
    {
        souls = 0;

        if (PlayerPrefs.HasKey("Souls"))
        {
            souls = PlayerPrefs.GetInt("Souls");
        }

        UpdateHUD();
    }

    public void SoulsCount(int count)
    {
        souls += count;
        UpdateHUD();
    }

    public void UpdateHUD()
    {
        //GameObject.Find("Canvas-HUD").GetComponent<HUDManager>().SetPlayersSouls(souls);
    }
}
