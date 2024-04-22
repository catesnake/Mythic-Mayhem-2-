using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour
{
    public GameObject enemy;
    [SerializeField] private GameObject Spawner;
    public float speed;
    public float spawnRate1 = 2;
    private float timer1 = 0;
    private int count1 = 1;
    private float timer2 = 0;
    private int count2 = 1;
    public float spawnRate2 = 2;
    public GameObject coin;


    // Update is called once per frame
    void Update()
    {
        Vector3 pos = new Vector3(Spawner.transform.position.x - speed, Spawner.transform.position.y, Spawner.transform.position.z);
        Spawner.transform.position = pos;

        if (timer1 < spawnRate1)
        {
            timer1 += Time.deltaTime;
        }
        else
        {
            Vector3 posEnemy = pos;
            posEnemy.z += Random.Range(-7.5f, 7.5f);
            Instantiate(enemy, posEnemy, transform.rotation);
            count1++;
            timer1 = 0;
            
        }

        if (timer2 < spawnRate2)
        {
            timer2 += Time.deltaTime;
        }
        else
        {
            Vector3 posCoin = pos;
            posCoin.z += Random.Range(-7.5f, 7.5f);
            posCoin.y = 1.5f;
            Instantiate(coin, posCoin, transform.rotation);
            count2++;
            timer2 = 0;

        }



    }
}
