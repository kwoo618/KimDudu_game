using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CCC_S : MonoBehaviour
{
    public int soundnumber;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        CC_sound.SoundPlay(soundnumber);
    }
}