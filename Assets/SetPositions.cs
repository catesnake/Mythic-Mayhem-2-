using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPositions : MonoBehaviour
{
    [SerializeField] private Camera mainCamera = FindAnyObjectByType<Camera>();

    // Start is called before the first frame update
    void Start()
    {
        mainCamera.transform.position = new Vector3(-2.58f, 13.35f, 1.23f);
    }

}
