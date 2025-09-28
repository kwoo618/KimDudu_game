using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraC : MonoBehaviour
{
    Vector3 base_pos;

    // Start is called before the first frame update
    void Start()
    {
        base_pos = Camera.main.gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LateUpdate()
    {
        Vector3 pos = this.transform.position;
        pos.z = -10;
        Camera.main.gameObject.transform.position = pos;
    }
}
