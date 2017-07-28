using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuSettingsManager : MonoBehaviour {


    public Color defaultPlayerNumberButton;
    public Color pressedPlayerNumberButton;

    public Image button2PlayerImage;
    public Image button3PlayerImage;
    public Image button4PlayerImage;


    // Use this for initialization
    void Start() {
        button2PlayerImage.color = defaultPlayerNumberButton;
        button3PlayerImage.color = defaultPlayerNumberButton;
        button4PlayerImage.color = defaultPlayerNumberButton;

        switch (Settings.playerNumber) {
            case 2:
                button2PlayerImage.color = pressedPlayerNumberButton;
                break;
            case 3:
                button3PlayerImage.color = pressedPlayerNumberButton;
                break;
            case 4:
                button4PlayerImage.color = pressedPlayerNumberButton;
                break;
        }

    }
        // Update is called once per frame
    void Update () {
		
	}

    public void Button2Player()
    {
        Settings.playerNumber = 2;

        button2PlayerImage.color = pressedPlayerNumberButton;
        button3PlayerImage.color = defaultPlayerNumberButton;
        button4PlayerImage.color = defaultPlayerNumberButton;
    }

    public void Button3Player()
    {
        Settings.playerNumber = 3;

        button2PlayerImage.color = defaultPlayerNumberButton;
        button3PlayerImage.color = pressedPlayerNumberButton;
        button4PlayerImage.color = defaultPlayerNumberButton;
    }

    public void Button4Player()
    {
        Settings.playerNumber = 4;

        button2PlayerImage.color = defaultPlayerNumberButton;
        button3PlayerImage.color = defaultPlayerNumberButton;
        button4PlayerImage.color = pressedPlayerNumberButton;
    }

    public void ButtonSave()
    {
        Settings.WriteSettings();
        SceneManager.LoadScene("MenuMain");
    }

}