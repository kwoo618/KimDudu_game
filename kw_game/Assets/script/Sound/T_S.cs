using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T_S : MonoBehaviour
{
    public int soundnumber;

    private void OnTriggerEnter2D(Collider2D other)
    {
        CC_sound.SoundPlay(soundnumber);
    }
}