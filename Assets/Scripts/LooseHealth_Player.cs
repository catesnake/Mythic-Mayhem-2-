using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LooseHealth_Player : MonoBehaviour
{
    public int health = 3;
    public Text healthText;


    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health: " + health.ToString("0");
        if (health == 0)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            health--;
        }

    }
}
