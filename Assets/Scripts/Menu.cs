using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject player;
    public int creature;
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
        creature = 1;
    }

    public void Dragon()
    {
        player.transform.GetChild(0).gameObject.SetActive(false);
        player.transform.GetChild(2).gameObject.SetActive(true);
        creature = 2;
    }
}
