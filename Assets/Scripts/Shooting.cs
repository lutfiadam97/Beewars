using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
	public Transform firePoint;
	public GameObject bulletPrefab;

	public float bulletForce = 50f;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
        	Shoot();
        }

    }

    void Shoot()
    {
    	Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }

}
