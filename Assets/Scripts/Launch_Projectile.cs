using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launch_Projectile : MonoBehaviour
{
    public GameObject projectile;
    [SerializeField] private GameObject projectileSpawner;
    public float spawnRate;
    private float timer = 0;


    // Update is called once per frame
    void Update()
    {

       if (Input.GetMouseButton(0))
        {
            if (timer < spawnRate)
            {
                timer += Time.deltaTime;
            }
            else
            {
                Instantiate(projectile, transform.position, transform.rotation);
                timer = 0;

            }
        }
        



    }
}
