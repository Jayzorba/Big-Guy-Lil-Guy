using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchDestroy : MonoBehaviour
{

    public GameObject blockToDestroy;
    // Start is called before the first frame update
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && Input.GetKeyDown(KeyCode.E))
        {
            Destroy(blockToDestroy);
        }
    }
}
