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

    void Start()
    {
        //coins += player.GetComponent<Player_Collect>().coinCount;
        //mainCoinText.text = "Coins: " + coins;
    }
    public void StartGame()
    {
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
        SceneManager.LoadScene(3);
    }

    public void Unicorn()
    {
        player.transform.GetChild(0).gameObject.SetActive(true);
        player.transform.GetChild(2).gameObject.SetActive(false);
    }

    public void Dragon()
    {
        player.transform.GetChild(0).gameObject.SetActive(false);
        player.transform.GetChild(2).gameObject.SetActive(true);
    }
}
