using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile_Movement : MonoBehaviour
{

    public float speed;
    void Update()
    {
        transform.position = new Vector3(transform.position.x - speed, transform.position.y, transform.position.z);
    }
}
