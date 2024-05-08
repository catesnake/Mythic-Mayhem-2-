using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load_NewLevel : MonoBehaviour
{
    [SerializeField] private GameObject Portal;
    [SerializeField] private Camera mainCamera;

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            mainCamera.transform.position = new Vector3(-2.58f, 13.35f, 1.23f);
        }

    }
}
