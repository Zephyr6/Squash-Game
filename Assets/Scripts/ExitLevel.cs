using UnityEngine;
using System.Collections;

public class ExitLevel : MonoBehaviour {

    public int NextLevel = 0;
    public AudioClip doorOpen = new AudioClip();
    public GameObject door;

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
            var coinCollector = other.GetComponent<CoinCollector>();
            if (coinCollector.AllCollected())
            {
                AudioSource.PlayClipAtPoint(doorOpen, transform.position);
                Destroy(door);
                Application.LoadLevel(NextLevel);
            }
        }
    }
}
