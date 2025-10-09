using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveV : MonoBehaviour
{
    public float speed = 1; //�ӵ� inspector�� ����

    void FixedUpdate()
    {
        this.transform.Translate(0, speed / 50, 0); //���� �̵��Ѵ�

    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
