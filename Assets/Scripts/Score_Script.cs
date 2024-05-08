using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_Script : MonoBehaviour
{
    public GameObject player;
    public Text scoreText;

    private void Start()
    {
        player = GameObject.Find("Player");
    }
    void Update()
    {
        scoreText.text = (-1*(player.transform.position.x)).ToString("0");
    }
}
