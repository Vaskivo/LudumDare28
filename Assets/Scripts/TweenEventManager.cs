using UnityEngine;
using System.Collections;

public class TweenEventManager : MonoBehaviour {

	public float end_push = 300f;
	public GameObject dat_child;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void StartTweenEvent(string name) {
		iTweenEvent.GetEvent(gameObject, name).Play();
	}

	public void LastPush() {
		Debug.Log ("PUSH!!!!");
		iTween.Stop();
		dat_child.transform.rigidbody.velocity = new Vector3(0, 0, -end_push); // HACK
	}
}
