using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HpUI2 : MonoBehaviour
{
    public static int hp =5;
    public static int numht =5;

    public Image[] hts;
    public Sprite full;
    public Sprite empty;

    void Update()
    {
        if(hp>numht)
        {
            hp = numht;
        }
        for (int i = 0; i < hts.Length; i++)
        {
            if (i < hp)
            {
                hts[i].sprite = full;
            }
            else if (i>=hp)
            {
                hts[i].sprite = empty;
            }
        }
    }
}