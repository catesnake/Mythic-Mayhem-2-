using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Movement : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    public float speed;
    public Transform t;


    void Update()
    {
        t.position = new Vector3(t.position.x - speed, t.position.y, t.position.z);
    }
}
