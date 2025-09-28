using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionStopGame : MonoBehaviour
{
    public string targetObjectName;

    void Start()
    {
        Time.timeScale = 1;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.name == targetObjectName)
        {
            Time.timeScale = 0;
        }
    }
}
