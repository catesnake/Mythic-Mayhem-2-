using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player_Collect : MonoBehaviour
{
    private int coinCount = 0;
    public Text coinText;

    // Update is called once per frame
    void Update()
    {
        Debug.Log(coinCount);
        coinText.text = "Coin: " + coinCount.ToString("0");
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Collectable")
        {
            Destroy(collision.gameObject);
            coinCount++;


        }

    }
}
