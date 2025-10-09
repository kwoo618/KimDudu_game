using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotaeY : MonoBehaviour
{
    public float angle = 90;

    void FixedUpdate()
    {
        this.transform.Rotate(0, angle / 50, 0);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
