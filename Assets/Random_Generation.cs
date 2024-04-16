using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_Generation : MonoBehaviour
{

    public GameObject enemy;
    public GameObject player;

    
    void Update()
    {
        Vector3 spawnLocation = player.transform.position;
        spawnLocation.x -= 10;
        
        if (Random.Range(0,1500) == 0)
        {
            Instantiate(enemy, spawnLocation, transform.rotation);
        }
    }
}
