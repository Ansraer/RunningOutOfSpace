using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

    }

    public static string[,] controls = new string[4,6]  { { "W", "D", "S", "A", "SPACE", "E" } , {"", "", "", "", "", ""}, { "", "", "", "", "", "" }, { "", "", "", "", "", "" } };
        

    public static void LoadSettings()
    {
        string playerOneButtoneDown = PlayerPrefs.GetString("PlayerOneButtonDown");
    }

    public static void WriteSettings()
    {
        PlayerPrefs.SetString("PlayerOneButtonDown", "S");
    }
}
