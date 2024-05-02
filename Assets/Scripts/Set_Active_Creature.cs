using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Set_Active_Creature : MonoBehaviour
{
    public GameObject ground;
    public GameObject player;
    
    public void Update()
    {
        Debug.Log(ground.GetComponent<Menu>().creature);
        
        if (ground.GetComponent<Menu>().creature == 1)
        {
            player.transform.GetChild(0).gameObject.SetActive(true);
            player.transform.GetChild(2).gameObject.SetActive(false);
        }
        else if (ground.GetComponent<Menu>().creature == 2)
        {
            player.transform.GetChild(0).gameObject.SetActive(false);
            player.transform.GetChild(2).gameObject.SetActive(true);
        }
    }
}
