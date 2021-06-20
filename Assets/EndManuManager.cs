using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndManuManager : MonoBehaviour
{

    public void LoadScene(string sceneName)
    {

        SceneManager.LoadScene(sceneName);
    }
    public void CloseApplication()
    {
        Application.Quit(); //tylko w buildzie
    }
}
