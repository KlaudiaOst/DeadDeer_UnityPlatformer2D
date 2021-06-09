using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float speed;
    public Transform pos1;
    public Transform pos2;
    public bool turnback;


    void Start()
    {
        
    }

    
    void Update()
    {
        if(transform.localPosition.y <= pos1.localPosition.y)
        {
            turnback = true;
        }
        if(transform.localPosition.y >= pos2.localPosition.y)
        {
            turnback = false;
        }
        if (turnback)
        {
            transform.localPosition = Vector2.MoveTowards(transform.localPosition, pos2.localPosition, speed * Time.deltaTime);
        }
        else
        {
            transform.localPosition = Vector2.MoveTowards(transform.localPosition, pos1.localPosition, speed * Time.deltaTime);
        }
    }
}
