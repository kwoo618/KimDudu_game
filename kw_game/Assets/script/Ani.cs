using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ani : MonoBehaviour
{
    public string targetObjectName;
    public string Anime = "";
    public string nowMode = "";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == targetObjectName)
        {
            nowMode = Anime;
        }
    }
    void FixedUpdate()
    {
        this.GetComponent<Animator>().Play(nowMode);
    }
}
