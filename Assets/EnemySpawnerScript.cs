using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour
{
    public GameObject enemy;
    public GameObject player;
    [SerializeField] private GameObject EnemySpawner;
    public float speed;
    public float spawnRate = 2;
    private float timer = 0;


    // Update is called once per frame
    void Update()
    {
        EnemySpawner.transform.position = new Vector3(EnemySpawner.transform.position.x - speed, EnemySpawner.transform.position.y, EnemySpawner.transform.position.z);

        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            Instantiate(enemy, transform.position, transform.rotation);
            timer = 0;
        }

        if (enemy.transform.position.x > (player.transform.position.x + 10))
        {
            Destroy(enemy);
        }
    }
}
