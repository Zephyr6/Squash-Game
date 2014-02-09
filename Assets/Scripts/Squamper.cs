using UnityEngine;
using System.Collections;

public class Squamper : MonoBehaviour {

    public AudioClip clip = new AudioClip();
    public bool IsFalling = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (IsFalling)
        {
            AudioSource.PlayClipAtPoint(clip, GameObject.FindGameObjectWithTag("MainCamera").transform.position, 1);
            if (other.tag == "Player")
                Destroy(other.gameObject);
        }
    }
}
