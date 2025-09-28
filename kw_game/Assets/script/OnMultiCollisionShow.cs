using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMultiCollisionShow : MonoBehaviour
{
    public string targetObjectName;
    public string showObjectName;

    GameObject showObject;

    void Start()
    {
        showObject = GameObject.Find(showObjectName);

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == targetObjectName)
        {
            Vector3 pos = showObject.transform.position;

            pos.x = 1;
            pos.y = 0;
            showObject.transform.position = pos;
        }
    }
}