using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelSpawner : MonoBehaviour
{
    public GameObject prefab;

    void Start()
    {
       StartCoroutine(SpawnBarrels());
    }

    
    void Update()
    {
        
    }

    public IEnumerator SpawnBarrels()
    {
        Instantiate(prefab, transform.position, transform.rotation);
        yield return new WaitForSeconds(2);
        StartCoroutine(SpawnBarrels());

    }
}
