using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject munition;
    public bool canShoot = true;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.J))
        {
            Shoot();
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            Shoot2();
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            Shoot3();
        }
    }


    private void Shoot()
    {
        if (canShoot)
        {
            canShoot = false;
            Invoke("Shooting", 0.5f);
            Instantiate(munition, transform);
            Invoke("ResetShoot", 1f);
        }
    }

    private void Shoot2()
    {
        if (canShoot)
        {
            canShoot = false;
            Invoke("Shooting", 0.5f);
            Invoke("Shooting", 0.5f);
            Instantiate(munition, transform);
            Invoke("ResetShoot", 1f);
        }
    }

    private void Shoot3()
    {
        if (canShoot)
        {
            canShoot = false;
            Invoke("Shooting", 0.5f);
            Invoke("Shooting", 0.5f);
            Invoke("Shooting", 0.5f);
            Instantiate(munition, transform);
            Invoke("ResetShoot", 1f);
        }
    }
    private void Shooting()
    {
        Instantiate(munition, transform);
    }

    private void ResetShoot()
    {
        canShoot = true;
    }
}
