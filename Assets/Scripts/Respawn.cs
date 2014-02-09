using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour 
{
	public bool respawn = false;
    PlayerLives PLives = new PlayerLives();

    void Start()
    {
        DontDestroyOnLoad(this);
    }

	void Update()
	{
        if (GameObject.Find("Player") == null)
        {
            respawn = true;
            PLives.lives = PLives.lives - 1;
        }

		if (respawn == true)
			respawnPlayer ();
	}

	void respawnPlayer()
	{
        respawn = false;
        Application.LoadLevel(Application.loadedLevel);
	}
}
