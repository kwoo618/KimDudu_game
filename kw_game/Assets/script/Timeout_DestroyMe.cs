using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timeout_DestroyMe : MonoBehaviour
{

    public float limitSec = 3;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, limitSec);
    }
}
