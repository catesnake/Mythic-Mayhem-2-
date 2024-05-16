using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject player;
    //public Text mainCoinText;
    public int coins;
    public GameObject gameScreen;

    void Start()
    {
        //coins += player.GetComponent<Player_Collect>().coinCount;
        //mainCoinText.text = "Coins: " + coins;
        gameScreen.SetActive(false);
        
    }

    private void Awake()
    {
        player = GameObject.FindWithTag("Player");
        gameScreen = GameObject.FindWithTag("GameScreen");
    }
    public void StartGame()
    {
        gameScreen.SetActive(true);
        SceneManager.LoadScene(4);
    }

    public void Shop()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Beasts()
    {
        gameScreen.SetActive(true);
        SceneManager.LoadScene(3);
    }

    public void Unicorn()
    {
        player.transform.GetChild(0).gameObject.SetActive(true);
        player.transform.GetChild(3).gameObject.SetActive(false);
        player.transform.GetChild(4).gameObject.SetActive(false);
    }

    public void Dragon()
    {
        player.transform.GetChild(0).gameObject.SetActive(false);
        player.transform.GetChild(3).gameObject.SetActive(true);
        player.transform.GetChild(4).gameObject.SetActive(false);
    }

    public void Duck()
    {
        player.transform.GetChild(0).gameObject.SetActive(false);
        player.transform.GetChild(3).gameObject.SetActive(false);
        player.transform.GetChild(4).gameObject.SetActive(true);
    }
}
