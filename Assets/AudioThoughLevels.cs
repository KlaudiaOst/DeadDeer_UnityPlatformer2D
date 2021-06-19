using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioThoughLevels : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
