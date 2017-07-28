using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour {


    void Start()
    {
        Settings.LoadSettings();
    }


    //triggered by button
    public void StartGame()
    {
        SceneManager.LoadScene("GameMain");
    }

    //triggered by button
    public void ShowScoreboard()
    {

    }

    //triggered by button
    public void ShowSettings()
    {
        SceneManager.LoadScene("MenuSettings");
    }

    //triggered by button
    public void Quit()
    {

    }
}
