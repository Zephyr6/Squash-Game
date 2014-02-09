using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour 
{
	public bool gameIsOver = false;

	void Update () 
	{
        if (gameIsOver)
        {
            Application.LoadLevel(1);
            gameIsOver = false;
        }
	}
}
