using UnityEngine;
using System.Collections;

public class NitroTouch : MonoBehaviour {

    public AudioClip touchSound = new AudioClip();

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update (){

	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            AudioSource.PlayClipAtPoint(touchSound, GameObject.FindGameObjectWithTag("MainCamera").transform.position, 1);
            Destroy(other.gameObject);
        }
    }
}
