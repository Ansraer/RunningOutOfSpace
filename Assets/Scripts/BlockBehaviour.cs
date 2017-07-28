using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBehaviour : MonoBehaviour {

    public BoxCollider trigger;
    public Rigidbody rigidBody;
    public float timeInSeconds = 0.5f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    // Triggers are placed on the collider boxes
    void OnTriggerEnter(Collider other)
    {

        StartCoroutine(FallDownAfterTime(timeInSeconds));




    }


    IEnumerator FallDownAfterTime(float time)
    {
        yield return new WaitForSeconds(time);

        rigidBody.useGravity = true;
    }
}
