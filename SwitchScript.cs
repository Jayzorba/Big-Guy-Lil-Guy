using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchScript : MonoBehaviour
{
    public Transform[] spawners;
    public GameObject platform;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.CompareTag("Player") && Input.GetKeyDown(KeyCode.E))
        {
         
            Debug.Log("clicker");
            foreach(Transform spawner in spawners)
            {
                SpawnPlatform(spawner);
            }
        }
    }

    void SpawnPlatform(Transform spawner)
    {
        Instantiate(platform, spawner.position, spawner.rotation);
    }
}
