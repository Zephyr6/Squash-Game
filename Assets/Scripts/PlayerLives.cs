using UnityEngine;
using System.Collections;

public class PlayerLives : MonoBehaviour 
{
	public int lives = 3;
	GameOver gameOver = new GameOver();

    void Start()
    {
        //DontDestroyOnLoad(Respawner);

    }

    void Update()
    {
        if (lives <= 0)
        {
            Dead();
        }
    }

	void Dead()
	{
		gameOver.gameIsOver = true;
	}
}
