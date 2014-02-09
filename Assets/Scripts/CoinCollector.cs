using UnityEngine;
using System.Collections;

public class CoinCollector : MonoBehaviour {

    private bool allCollected = false;
    public int CoinsToWin = 5;
    public int collectedCoins = 0;

	// Use this for initialization
	void Start () {
        collectedCoins = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (collectedCoins == CoinsToWin)
        {
            allCollected = true;
        }
	}

    public bool AllCollected()
    {
        return allCollected;
    }

    public void AddCoinToCollection()
    {
        collectedCoins++;
    }
}
