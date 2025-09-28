using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BHUI : MonoBehaviour
{
    public int bosshp = 3;
    public int numht = 3;

    public Image[] hts;
    public Sprite full;
    public Sprite empty;

    void Update()
    {
        if (bosshp > numht)
        {
            bosshp = numht;
        }
        for (int i = 0; i < hts.Length; i++)
        {
            if (i < bosshp)
            {
                hts[i].sprite = full;
            }
            else if (i >= bosshp)
            {
                hts[i].sprite = empty;
            }
        }
    }
}