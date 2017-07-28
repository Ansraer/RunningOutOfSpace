using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour {

    public int playerNumber;

    private string buttonForward = "W";
    private string buttonRight = "D";
    private string buttonDown = "S";
    private string buttonLeft= "A";




    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Vector2 direction = new Vector2();

 
        direction.y += 1;

        //change direction



        this.gameObject.transform.Translate(new Vector3(direction.x, 0, direction.y));
	}
}
