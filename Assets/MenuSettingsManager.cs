using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuSettingsManager : MonoBehaviour {


    public Button button2Player;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Button2Player()
    {
        Settings.playerNumber = 2;
    }

    public void Button3Player()
    {
        Settings.playerNumber = 3;
    }

    public void Button4Player()
    {
        Settings.playerNumber = 4;
    }


}
