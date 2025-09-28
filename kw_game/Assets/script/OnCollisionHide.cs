using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionHide : MonoBehaviour
{
    public string targetObjectName;
    public string hideObjectName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == targetObjectName)
        {
            GameObject hideObject = GameObject.Find(hideObjectName);
            hideObject.SetActive(false);
        }
    }
}
