using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oncolball : MonoBehaviour
{
    public int soundnumber;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // 충돌한 오브젝트가 주인공인지 확인
        if (collision.gameObject.CompareTag("Player"))
        {
            CC_sound.SoundPlay(soundnumber);
        }
    }
}
