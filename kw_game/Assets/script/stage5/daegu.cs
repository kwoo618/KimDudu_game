using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class daegu : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            daeguscore.daeguAmount += 1;
            Destroy(gameObject);
        }
    }
}
