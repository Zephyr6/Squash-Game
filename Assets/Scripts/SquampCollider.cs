using UnityEngine;
using System.Collections;

public class SquampCollider : MonoBehaviour {

    public AudioClip clip = new AudioClip();
    public float TimeToSquamp = 5.0f;
    private float timer = 0;
    private Vector3 startPosition = new Vector3();
    private float fallSpeed = 10;
	// Use this for initialization
	void Start () {
        timer = TimeToSquamp;
	}
	
	// Update is called once per frame
	void Update () {
        if (timer <= 0)
        {
            rigidbody2D.velocity = new Vector2(0, -fallSpeed);
            timer = TimeToSquamp;
        }
        else
        {
            timer -= Time.deltaTime;
        }

        if (GetComponentInChildren<SquampGrounded>().IsGrounded)
        {
            rigidbody2D.velocity = new Vector2(0, fallSpeed);
        }

        rigidbody2D.velocity = new Vector2(0, rigidbody2D.velocity.y);
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        AudioSource.PlayClipAtPoint(clip, GameObject.FindGameObjectWithTag("MainCamera").transform.position);
        if (other.tag == "Player")
        {
            Destroy(other.gameObject);
        }
    }
}
