using UnityEngine;
using System.Collections;

public class GameOverRestart : MonoBehaviour {
    void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Application.LoadLevel(0);
        }
	}
}
