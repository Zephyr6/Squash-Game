using UnityEngine;
using System.Collections;

public class Squamper : MonoBehaviour {

    public AudioClip clip = new AudioClip();
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        AudioSource.PlayClipAtPoint(clip, transform.position);
        if (other.tag == "Player")
        {
            Destroy(other.gameObject);
        }
    }
}
