using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting_script : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    public float bulletForce = 20f;
    public static float firerate = 20f;
    private float lastShootTime = 0;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {

            if(Time.time > lastShootTime + firerate)
            {

                shoot();
                lastShootTime = Time.time;
            }

         
        }


       
    }

    void shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.right * bulletForce, ForceMode2D.Impulse);
    }



}
