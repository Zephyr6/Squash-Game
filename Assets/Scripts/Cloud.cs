using UnityEngine;
using System.Collections;

public class Cloud : MonoBehaviour {

	void Awake () {
        rigidbody2D.velocity = new Vector2(-0.2F, 0);
	}
}
