using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Movement : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    public float speed;
    void Update()
    {
        mainCamera.transform.position = new Vector3(mainCamera.transform.position.x - speed, mainCamera.transform.position.y, mainCamera.transform.position.z);
    }
}
