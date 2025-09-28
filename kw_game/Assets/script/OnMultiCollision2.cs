using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMultiCollision2 : MonoBehaviour
{
    public string targetObjectName;
    public string hideObjectName;

    GameObject hideObject;

    void Start()
    {
        hideObject = GameObject.Find(hideObjectName);
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == targetObjectName)
        {
            Vector3 pos = hideObject.transform.position;

            pos.x = 1;
            pos.y = 0;
            hideObject.transform.position = pos;
        }
    }
}
