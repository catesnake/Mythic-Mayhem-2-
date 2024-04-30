using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collect_Coin : MonoBehaviour
{
    private int coinCount = 0;
    public Text coinText;

    void Update()
    {
        Debug.Log(coinCount);
        coinText.text = "Coins: " + coinCount.ToString("0");
    }
    
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            coinCount++;
            

        }

    }

}
