using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Scene : MonoBehaviour
{


    public void RestartLevel(Player player)
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
#if UNITY_ANDROID || UNITY_EDITOR

    public void CloseApp()
    {
        Application.Quit();
    }
#endif

}
