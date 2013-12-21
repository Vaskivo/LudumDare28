using UnityEngine;
using System.Collections;


public class EndScreenResultScript : MonoBehaviour {

    string[] winResults = {   "a nobel prize winner",
                              "a new baby doctor",
                              "a great artist",
                              "a regular hardworking citizen"};

 //   string[] failResults = { "its a murderer", "its stupid", "" };

	// Use this for initialization
	void Start () {

        int r = Random.Range(0, winResults.Length);

        string s = winResults[r];
        TextMesh t = (TextMesh)gameObject.GetComponent(typeof(TextMesh));
        t.text = "Your success led to\n" + s;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
