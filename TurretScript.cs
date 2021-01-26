using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretScript : MonoBehaviour
{
    public Transform muzzle;
    public GameObject bullet;
    float shootInterval = 5.0f;

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        shootInterval -= Time.deltaTime;
        if (shootInterval <= 0)
        {
            Shoot();
            shootInterval = 5;
        }
    }

    public void Shoot()
    {
        Instantiate(bullet,muzzle.position,muzzle.rotation);
    }
}
