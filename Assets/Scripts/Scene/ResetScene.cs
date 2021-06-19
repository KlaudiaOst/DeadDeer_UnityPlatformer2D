using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetScene : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //GameObject.Find("Player").GetComponent<PlayerHealth>().Die();
        PlayerPrefs.SetInt("Health", 5);
        PlayerPrefs.SetInt("Coins", 0);
        PlayerPrefs.SetInt("Souls", 0);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
