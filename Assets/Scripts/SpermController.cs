using UnityEngine;
using System.Collections;

public class SpermController : MonoBehaviour {
	
	private bool going_up = false;
	private bool going_down = false;
	private bool going_left = false;
	private bool going_right = false;

	private Vector3 current_rotation = Vector3.zero;
	private Vector3 translated = Vector3.zero;

	public float speed = 10f;
	public float resistance = 0.01f;
	public float rotation = 20f;
	public float movement_radius = 150f;

	public GameObject sperm = null;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
//		Debug.Log("TIME: " + Time.fixedTime);

		Vector3 rot = Vector3.zero;

		sperm.transform.rotation = new Quaternion();
		if (Input.GetKeyDown(KeyCode.A)) {
			going_left = true;
			rot += new Vector3(0, -rotation, 0);
		} 
		if (Input.GetKeyUp(KeyCode.A)) {
			going_left = false;
			rot += new Vector3(0, rotation, 0);
		}
		if (Input.GetKeyDown(KeyCode.D)) {
			going_right = true;
			rot += new Vector3(0, rotation, 0);
		} 
		if (Input.GetKeyUp(KeyCode.D)) {
			going_right = false;
			rot += new Vector3(0, -rotation, 0);
		}
		if (Input.GetKeyDown(KeyCode.W)) {
			going_up = true;
			rot += new Vector3(-rotation, 0, 0);
		} 
		if (Input.GetKeyUp(KeyCode.W)) {
			going_up = false;
			rot += new Vector3(rotation, 0, 0);
		}
		if (Input.GetKeyDown(KeyCode.S)) {
			going_down = true;
			rot += new Vector3(rotation, 0, 0);
		} 
		if (Input.GetKeyUp(KeyCode.S)) {
			going_down = false;
			rot += new Vector3(-rotation, 0, 0);
		}

		current_rotation += rot;

		sperm.transform.rotation = new Quaternion();
		sperm.transform.Rotate(current_rotation);

		setVelocity();
	}

	
	private void setVelocity() {

		Vector3 translation = Vector3.zero;
		if (going_up) {
			translation += new Vector3(0, 1, 0);
		}

		if (going_down) {
			translation += new Vector3(0, -1, 0);
		}

		if (going_left) {
			translation += new Vector3(-1, 0, 0);
		}

		if (going_right) {
			translation += new Vector3(1, 0, 0);
		}
		translation = translation.normalized * speed;

		Vector3 resist = -(translated * resistance);

		if ((translation + translated).magnitude > movement_radius) {
			translation = translation.normalized * (movement_radius - translated.magnitude);
		}
		translation += resist;

//		Debug.Log(translated.ToString());
		gameObject.transform.Translate(translation, Space.Self);
		translated += translation;
	}
}
