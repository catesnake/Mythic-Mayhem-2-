using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_Script : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    void Update()
    {
        scoreText.text = (-1*(player.position.x)).ToString("0");
    }
}
