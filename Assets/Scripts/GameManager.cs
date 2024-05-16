using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameObject camera;

    public int coins;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        // end of new code

        Instance = this;
        DontDestroyOnLoad(gameObject);
        Debug.Log("scence: "+SceneManager.GetActiveScene().buildIndex);
        camera = GameObject.FindWithTag("MainCamera");
    }

    private void Start()
    {
        camera.transform.position = new Vector3(-2.58f, 13.35f, 1.23f);
    }
}
