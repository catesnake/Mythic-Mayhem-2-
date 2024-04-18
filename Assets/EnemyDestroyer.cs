using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyDestroyer : MonoBehaviour
{
    [SerializeField] private GameObject ED;
    public float speed;
    public float sphereRadius;
    void Update()
    {
        ED.transform.position = new Vector3(ED.transform.position.x - speed, ED.transform.position.y, ED.transform.position.z);


    }

   void OnTriggerEnter(Collider collision)
   {
       if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
        } 
        
   }

}
