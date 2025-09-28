using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TT : MonoBehaviour
{
    public string targetObjectName;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == targetObjectName)
        {
            Destroy(gameObject);
        }
    }
}