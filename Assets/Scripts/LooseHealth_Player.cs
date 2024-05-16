using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LooseHealth_Player : MonoBehaviour
{
    public int health = 3;
    public Text healthText;
    public GameObject gameOverUI;
    public bool loaded = true;
    public GameObject gameScreen;


    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health: " + health.ToString("0");
        if (health == 0 && loaded)
        {
            loaded = false;
            gameScreen.SetActive(false);
            SceneManager.LoadScene(1);
        }
    }

    private void Awake()
    {
        gameScreen = GameObject.FindWithTag("GameScreen");
    }
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            health--;
        }

    }
}
