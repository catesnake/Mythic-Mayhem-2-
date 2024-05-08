using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collect_Coin : MonoBehaviour
{
    public int coinCount = GameManager.Instance.coins;
    public Text coinText;

    private void Start()
    {
        coinCount = GameManager.Instance.coins;
    }
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
            GameManager.Instance.coins += coinCount;
        }

    }

}
