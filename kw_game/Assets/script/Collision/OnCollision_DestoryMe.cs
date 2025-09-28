using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision_DestoryMe : MonoBehaviour
{

    public string targetObjectName;
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == targetObjectName)
        {
            Destroy(this.gameObject);
        }
    }
}
