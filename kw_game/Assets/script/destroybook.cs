using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroybook : MonoBehaviour
{
    public HpUI2 hpp;
    public string targetObjectName;
    public int soundnumber;

    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == targetObjectName)
        {
            if (bookScore.bookAmount == 5)
            {
                bookScore.bookAmount = 0;
                Destroy(this.gameObject);
                CC_sound.SoundPlay(soundnumber);

            }
        }
    }
}
