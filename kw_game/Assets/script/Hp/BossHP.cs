using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHP : MonoBehaviour
{
    public BHUI bhp;
    public string DestroyName;
    public GameObject bosshp;
    public int soundnumber;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(daeguscore.daeguAmount>=1)
        {
            if (other.CompareTag("Player"))
            {
                bhp.bosshp -= 1;
                CC_sound.SoundPlay(soundnumber);
                daeguscore.daeguAmount -= 1;
            }

            if (bhp.bosshp <= 0)
            {
                Destroy(GameObject.Find(DestroyName));
                bosshp.SetActive(false);
            }
        }
    }
}