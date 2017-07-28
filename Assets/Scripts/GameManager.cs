using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public Transform groundCube;
    public Transform playerPrefab;


	// Use this when the game starts
	void Start () {
        int length = 20;
        int width = 20;
        for(int i = 0; i<length; i++)
        {
            for(int j = 0; j<width; j++)
            {
                Instantiate(groundCube, new Vector3(i, 0, j), Quaternion.identity);
            }
        }
        Instantiate(playerPrefab, new Vector3(5,1,5), Quaternion.identity)); 
        if (Settings.playerNumber >= 2)
        {
            Instantiate(playerPrefab, new Vector3(15,1,15), Quaternion.identity));
        }

	}
	
	// Update is called once per frame for graphics stuff
	void Update () {
		
	}

    // Update is called once per game tick
    void FixedUpdate()
    {

    }
}
