using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialAttack : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    
    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        { 
            //dodatkowy if ze skryptu z zebranymi duszami 
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject go =  Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        SpecialAttackBullet sab = go.GetComponent<SpecialAttackBullet>();
        StartCoroutine(sab.WaitAndShoot(transform.localScale.x));
    }
}
