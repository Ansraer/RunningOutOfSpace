using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBehaviour : MonoBehaviour {

    public BoxCollider trigger;
    public Rigidbody rigidBody;
    public float fallDownDelayInSeconds = 0.5f;
    public float destroyCubeDelayInSeconds = 0.5f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    // Triggers are placed on the collider boxes
    void OnTriggerEnter(Collider other)
    {

        if(other.gameObject.tag == "Player")

        StartCoroutine(FallDownAfterTime());




    }


    IEnumerator FallDownAfterTime()
    {
        yield return new WaitForSeconds(fallDownDelayInSeconds);
        rigidBody.useGravity = true;
        yield return new WaitForSeconds(destroyCubeDelayInSeconds/3 + Random.Range(0, destroyCubeDelayInSeconds*2));
        Destroy(this.gameObject);

    }
}
