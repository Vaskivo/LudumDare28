using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class OtherSpermBehaviour : MonoBehaviour {

	public Vector3 translation = Vector3.zero;
	public float speed = 50;
	public string nodes = "";
	public float delay = 0;
	public float timeToLive = 0;


	// Use this for initialization
	void Start () {
//		List<Vector3> path = new List<Vector3>();
//		Debug.Log(path.Capacity);
//		string[] new_nodes = nodes.Split(',');
//		if (new_nodes.Length % 3 != 0) {
//			// YOU ARE BAD AND YOU SHOULD FELL BAD ABOUT IT!
//			return;
//		}
//
//		for (int i=0; i < new_nodes.Length; i+=3) {
//			path.Add(new Vector3(float.Parse(new_nodes[i]), 
//			                     float.Parse(new_nodes[i+1]), 
//			                     float.Parse(new_nodes[i+2])));
//		}
//
//		Debug.Log(path.Capacity);
//
//		iTween.MoveTo(gameObject, iTween.Hash("speed", 0,
//		                                      "path", path.ToArray(),
//		                                      "orienttopath", true,
//		                                      "looktime", 0.1,
//		                                      "easetype", iTween.EaseType.linear,
//		                                      "delay", delay));
//		gameObject.transform.Translate(translation, Space.Self);
		StartCoroutine(StartMoving(delay));
	}
	
	// Update is called once per frame
	void Update () {
//		gameObject.transform.Translate(translation, Space.Self);

	}

	IEnumerator StartMoving(float waitTime) {
		yield return new WaitForSeconds(waitTime);
		gameObject.transform.rigidbody.velocity = gameObject.transform.TransformDirection(new Vector3(0, 0, speed));
		if ( timeToLive > 0) {
			StartCoroutine(DestroySelf(timeToLive));
		}
	}

	IEnumerator DestroySelf(float waitTime) {
		yield return new WaitForSeconds(waitTime);
		GameObject.Destroy(gameObject);
	}
}
