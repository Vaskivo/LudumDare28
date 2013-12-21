using UnityEngine;
using System.Collections;

public class PlayerCollisions : MonoBehaviour {

    public GameObject explosion;
	public float death_delay = 2f;
    public AudioSource audio_sc;
    public AudioSource audio2;
    private bool crossfade = false;
    
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (crossfade)
        {
            crossfadef(audio_sc, audio2);
        }
	}

    void OnTriggerEnter(Collider other)
    {	
		if (other.gameObject.tag.Equals("ENEMY")) {
			StartCoroutine(Death(death_delay));
        }
        else if (other.gameObject.tag.Equals("MUSIC"))
        {
            audio2.volume = 0;
            audio2.Play();
            crossfade = true;
        }
    }

	IEnumerator Death(float waitTime) {
		iTween.Stop();
		if ( explosion != null) {
			Instantiate(explosion, gameObject.transform.position, gameObject.transform.rotation);
		}
//		GameObject.Destroy(gameObject);
		gameObject.transform.Translate(new Vector3(10000,10000,10000)); // mega HACK
		yield return new WaitForSeconds(waitTime);
		Application.LoadLevel("BadEnding");
	}

    private void crossfadef(AudioSource a1, AudioSource a2)
    {
        a1.volume = a1.volume - 1;
        a2.volume = a2.volume + 1;
        if( a1.volume <= 0)
        {
            crossfade = false;
        }
    }
}
