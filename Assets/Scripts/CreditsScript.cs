using UnityEngine;
using System.Collections;

public class CreditsScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.position += new Vector3(0, 0.1f, 0);
        if (gameObject.transform.position.y > 45)
        {
            gameObject.transform.position = new Vector3(-5, -45, -1);
        }
	}
}
