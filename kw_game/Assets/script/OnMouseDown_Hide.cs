using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouseDown_Hide : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        this.gameObject.SetActive(false);
    }
}
