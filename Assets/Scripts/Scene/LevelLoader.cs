using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public string sceneNameToLoad;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                int health = GameObject.Find("Player").GetComponent<PlayerHealth>().health;
                PlayerPrefs.SetInt("Health", health);

                int coins = GameObject.Find("Player").GetComponent<PlayerScore>().coins;
                PlayerPrefs.SetInt("Coins", coins);

                int souls = GameObject.Find("Player").GetComponent<PlayerSouls>().souls;
                PlayerPrefs.SetInt("Souls", souls);

                SceneManager.LoadScene(sceneNameToLoad);
            }
        }
    }
}
