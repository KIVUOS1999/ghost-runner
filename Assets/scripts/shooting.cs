using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bullet;
    public float bulletforce;

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            shoot();
        }
    }

    void shoot()
    {
        GameObject bullet_come = Instantiate(bullet,firepoint.position, firepoint.rotation);
        Rigidbody2D rb = bullet_come.GetComponent<Rigidbody2D>();
        rb.AddForce(firepoint.up * bulletforce, ForceMode2D.Impulse);
        Destroy(bullet_come, 2f);
    }
}
