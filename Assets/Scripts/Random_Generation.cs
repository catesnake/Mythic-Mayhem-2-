using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_Generation : MonoBehaviour
{

    public GameObject enemy;
    public GameObject player;
    public float spawnRate = 2;
    private float timer = 0;

    
    void Update()
    {
        Vector3 spawnLocation = player.transform.position;
        spawnLocation.x -= 30;
        
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            Instantiate(enemy, spawnLocation, transform.rotation);
            timer = 0;
        }
        
        if (enemy.transform.position.x > (player.transform.position.x +10))
        {
            Destroy(enemy);
        }
    }
}
