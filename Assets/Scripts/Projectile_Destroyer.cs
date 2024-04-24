using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile_Destroyer : MonoBehaviour
{
    [SerializeField] private GameObject PD;
    public float speed;
    void Update()
    {
        PD.transform.position = new Vector3(PD.transform.position.x - speed, PD.transform.position.y, PD.transform.position.z);


    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Projectile")
        {
            Destroy(collision.gameObject);
        }

    }
}
