using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleLight : MonoBehaviour
{
    private Light mylight;

    void Start()
    {
        mylight = GetComponent<Light>();       
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Q)) {
            //mylight.enabled = false;
            mylight.enabled = !mylight.enabled;
        }
    }
}
