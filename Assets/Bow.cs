using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    float nextAttackTime = 0f;
    public float attackRate = 2f;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot ()
    {
        GameObject go = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        go.GetComponent<Bullet>().SetVelocity(transform.localScale.x);
        nextAttackTime = Time.time + 1f / attackRate;
    }
}
