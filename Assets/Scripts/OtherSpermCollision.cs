using UnityEngine;
using System.Collections;

public class OtherSpermCollision : MonoBehaviour {

	public GameObject explosion; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other)
	{	
//		Debug.Log("NPC collision with " + other.gameObject.tag);
		if (other.gameObject.tag.Equals("ENEMY")) {
			if (explosion != null) {
				Instantiate(explosion, gameObject.transform.position, gameObject.transform.rotation);
			}
			GameObject.Destroy(gameObject);
		}
	}
}
