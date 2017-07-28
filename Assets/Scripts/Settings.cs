using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour {

    public static string[,] controls = new string[4, 6] { { "W", "D", "S", "A", "SPACE", "E" }, { "", "", "", "", "", "" }, { "", "", "", "", "", "" }, { "", "", "", "", "", "" } };
    //The button names are used to save the settings
    public static string[] buttonNames = new string[6] { "Up", "Down", "Left", "Right", "Jump", "Item" };

    public static int playerNumber = 2;


    // Use this for initialization
    void Start()
    {
        
    }

    //naming: "Player" + number(e.g. 1) + "Button" + Button ("Up", "Down", "Left", "Right", "Jump", "Item")

    public static void LoadSettings()
    {
        //load controls
        int players = 4;
        for (int i = 1; i<=players; i++)
        {
            for (int j = 0; j<buttonNames.Length; j++)
            {
                string query = "Player" + i.ToString() + "Button" + buttonNames[j];
                //Deduct 1 from player since array starts at 0 but first player is Player1
                controls[i - 1, j] = getString(query, controls[i - 1, j]);
            }
        }

        //load player number
        if (PlayerPrefs.HasKey("PlayerNumber"))
            playerNumber = PlayerPrefs.GetInt("PlayerNumber");

    }

    public static void WriteSettings()
    {
        int players = 4;
        for (int i = 1; i <= players; i++)
        {
            for (int j = 0; j < buttonNames.Length; j++)
            {
                string query = "Player" + i.ToString() + "Button" + buttonNames[j];
                //Deduct 1 from player since array starts at 0 but first player is Player1
                PlayerPrefs.SetString(query, controls[i-1,j]);
            }
        }


        PlayerPrefs.SetInt("PlayerNumber", playerNumber);

        PlayerPrefs.Save();
    }

    public static string getString(string key, string otherwise)
    {
        if (PlayerPrefs.HasKey(key))
        {
            return PlayerPrefs.GetString(key);
        }
        else
        {
            return otherwise;
        }

    }


    public static void testSettings()
    {
        Debug.Log("Starting settings debugging");
        LoadSettings();
        Debug.Log("Loaded settings:");
        Debug.Log(controls[0,0]);
        controls[0, 0] = "Test";
        Debug.Log(controls[0,0]);
    }
}
