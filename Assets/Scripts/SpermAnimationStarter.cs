using UnityEngine;
using System.Collections;

public class SpermAnimationStarter : MonoBehaviour {

	public float animetionSpeed = 20f;

	// Use this for initialization
	void Start () {
		animation["Take 001"].speed = animetionSpeed;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
