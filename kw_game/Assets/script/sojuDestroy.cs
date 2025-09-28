using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sojuDestroy : MonoBehaviour
{
    public string targetObjectName;
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == targetObjectName)
        {
            if (ScoreSoju.sojuAmount == 5)
            {
                ScoreSoju.sojuAmount = 0;
                Destroy(this.gameObject);
            }
            else
            {
                collision.gameObject.transform.position = Vector3.zero;
                HpUI2.hp -= 1;
            }
        }
    }
}

