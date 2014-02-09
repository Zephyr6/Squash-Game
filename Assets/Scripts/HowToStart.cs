using UnityEngine;
using System.Collections;

public class HowToStart : MonoBehaviour {
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Application.LoadLevel(3);
        }
	}
}
