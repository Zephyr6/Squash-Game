using UnityEngine;
using System.Collections;

public class CameraDirector : MonoBehaviour {

	// Use this for initialization
	void Start () {
        if(GameObject.FindGameObjectWithTag("Player") != null)
        {
            var playerObject = GameObject.FindGameObjectWithTag("Player");
            transform.position = new Vector3(playerObject.transform.position.x, playerObject.transform.position.y, transform.position.z);
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            var playerObject = GameObject.FindGameObjectWithTag("Player");
            transform.position = new Vector3(playerObject.transform.position.x, playerObject.transform.position.y, transform.position.z);
        }
	}
}
