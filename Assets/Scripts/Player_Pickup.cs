using UnityEngine;
using System.Collections;

public class Player_Pickup : MonoBehaviour {

    public AudioClip collectSound = new AudioClip();
    public string letter = "";
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            AudioSource.PlayClipAtPoint(collectSound, GameObject.FindGameObjectWithTag("MainCamera").transform.position);
            Destroy(gameObject);
        }
    }
}
