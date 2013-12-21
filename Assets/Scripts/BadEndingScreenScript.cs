using UnityEngine;
using System.Collections;


public class BadEndingScreenScript : MonoBehaviour
{

    string[] failResults = { "a murderer", "a nobel prize\ngood thing you failed!", "nothing" };

    // Use this for initialization
    void Start()
    {

        int r = Random.Range(0, failResults.Length);

        string s = failResults[r];
        TextMesh t = (TextMesh)gameObject.GetComponent(typeof(TextMesh));
        t.text = "Your failure led to\n" + s;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
