using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Projectile : MonoBehaviour
{

    
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision)
    {
            Destroy(this.gameObject);

    }
}
