using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;

public class Player_Movement : MonoBehaviour
{
    public Rigidbody rigidbody;

    private void Start()
    {
        InvokeRepeating("SetPlayerPosition", 0f, 10f);
    }

    void SetPlayerPosition()
    {
        rigidbody.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, 1, Input.mousePosition.z));
    }
}
