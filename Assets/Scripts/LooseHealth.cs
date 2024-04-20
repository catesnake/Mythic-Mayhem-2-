using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LooseHealth : MonoBehaviour
{
    public int health = 1;
   
    // Update is called once per frame
    void Update()
    {
        if (health == 0)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Projectile")
        {
            health--;
        }

    }
}
