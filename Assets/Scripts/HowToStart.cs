using UnityEngine;
using System.Collections;

public class HowToStart : MonoBehaviour {
    public int level = 3;
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Application.LoadLevel(level);
        }
	}
}
