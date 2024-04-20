using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Movement : MonoBehaviour
{
    public  GameObject player;
    public float speed;
    [SerializeField] private Camera mainCamera;
    [SerializeField] private LayerMask layerMask;
    Vector3 vec;

    // Update is called once per frame
    void Update()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit raycastHit, float.MaxValue, layerMask))
        {

            vec = raycastHit.point;
            vec.y = 1f;
        }

        if (vec.z > transform.position.z)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + speed);
        }
        else if (vec.z < transform.position.z)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - speed);
        }
    }
    
}
