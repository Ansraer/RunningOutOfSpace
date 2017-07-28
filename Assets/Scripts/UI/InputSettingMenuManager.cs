using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputSettingMenuManager : MonoBehaviour {

    public int playerNumber;

    public Color idleColor;
    public Color activeColor;

    public Image buttonUp;
    public Image buttonDown;
    public Image buttonLeft;
    public Image buttonRight;
    public Image buttonJump;
    public Image buttonAction;

    public Text buttonUpText;
    public Text buttonDownText;
    public Text buttonLeftText;
    public Text buttonRightText;
    public Text buttonJumpText;
    public Text buttonActionText;


    //if the game is waiting for a control key input;
    private bool catching = false;
    private int catchingFor = 0;


    // Use this for initialization
    void Start () {
        setAllIdle();
        setAllText();
	}
	
	// Update is called once per frame
	void Update () {
        if(catching)
            catchKey();
	}


    void setAllIdle(){
        buttonUp.color = idleColor;
        buttonDown.color = idleColor;
        buttonRight.color = idleColor;
        buttonLeft.color = idleColor;
        buttonAction.color = idleColor;
        buttonJump.color = idleColor;
    }

    void setAllText()
    {
        buttonUpText.text = Settings.controls[this.playerNumber, 0];
        buttonDownText.text = Settings.controls[this.playerNumber, 1];
        buttonLeftText.text = Settings.controls[this.playerNumber, 2];
        buttonRightText.text = Settings.controls[this.playerNumber, 3];
        buttonJumpText.text = Settings.controls[this.playerNumber, 4];
        buttonActionText.text = Settings.controls[this.playerNumber, 5];
    }


    public void ButtonUp()
    {
        buttonUp.color = activeColor;
        buttonUpText.text = "";
        catching = true;
        catchingFor = 0;
    }

    public void ButtonDown()
    {
        buttonDown.color = activeColor;
        buttonDownText.text = "";
        catching = true;
        catchingFor = 1;
    }

    public void ButtonLeft()
    {
        buttonLeft.color = activeColor;
        buttonLeftText.text = "";
        catching = true;
        catchingFor = 2;
    }

    public void ButtonRight()
    {
        buttonRight.color = activeColor;
        buttonRightText.text = "";
        catching = true;
        catchingFor = 3;
    }

    public void ButtonJump()
    {
        buttonJump.color = activeColor;
        buttonJumpText.text = "";
        catching = true;
        catchingFor = 4;

    }

    public void ButtonAction()
    {
        buttonAction.color = activeColor;
        buttonActionText.text = "";
        catching = true;
        catchingFor = 5;
    }


    string catchKey()
    {
        string pressedKey="";
        if (Input.anyKeyDown && !Input.GetMouseButton(0) && !Input.GetMouseButton(1) && !Input.GetMouseButton(2))
        {
            Debug.Log("got keypress");
            pressedKey = Input.inputString;
            catching = false;
            handleCatchedKey(pressedKey, this.catchingFor);
            //hasKey = true;
        }


        return pressedKey;
    }

    private void handleCatchedKey(string key, int type)
    {

        Debug.Log(key);

        Settings.controls[this.playerNumber,type] = key;

        setAllText();
        setAllIdle();
    }
}
