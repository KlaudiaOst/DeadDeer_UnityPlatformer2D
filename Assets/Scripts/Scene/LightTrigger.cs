using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTrigger : MonoBehaviour
{
    private Light mylight;
    public float range;
    void Start()
    {
        mylight = GetComponent<Light>();
        mylight.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            mylight.range = range;
            mylight.enabled = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            mylight.range = range;
            mylight.enabled = false;
        }
    }
}
