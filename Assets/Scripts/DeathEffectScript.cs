using UnityEngine;
using System.Collections;

public class DeathEffectScript : MonoBehaviour {

	public float death_delay = 2f;

	// Use this for initialization
	void Start () {
		StartCoroutine(DestroySelf(death_delay));
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator DestroySelf(float waitTime) {
		yield return new WaitForSeconds(waitTime);
		GameObject.Destroy(gameObject);
	}
}
