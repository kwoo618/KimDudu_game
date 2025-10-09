using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnKeyPress_MoveSprite : MonoBehaviour
{
    public float speed = 2;

    float vx = 0;
    float vy = 0;
    

    void Update()
    {
        vx = 0;
        vy = 0;
        if (Input.GetKey("right"))
        {
            vx = speed;
            
        }
        if (Input.GetKey("left"))
        {
            vx = -speed;
            
        }
        if (Input.GetKey("up"))
        {
            vy = speed;
        }
        if (Input.GetKey("down"))
        {
            vy = -speed;
        }
    }
    void FixedUpdate()
    {
        this.transform.Translate(vx / 50, vy / 50, 0);

    }
}
