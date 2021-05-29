using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject firstMenuView;
    public GameObject secondMenuView;

    public void ShowFirstMenuView()
    {
        firstMenuView.SetActive(true);
        secondMenuView.SetActive(false);
    }
    public void ShowSecondMenuView()
    {
        firstMenuView.SetActive(false);
        secondMenuView.SetActive(true);
    }

    public void LoadScene(string sceneName)
    {
        PlayerPrefs.SetInt("Health", 3);
        SceneManager.LoadScene(sceneName);
    }
    public void CloseApplication()
    {
        Application.Quit(); //tylko w buildzie
    }
}
