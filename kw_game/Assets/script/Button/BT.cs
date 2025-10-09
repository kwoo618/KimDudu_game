using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FixedAspectRatio : MonoBehaviour
{
    // ���ϴ� ����
    public float targetAspect = 2f / 1f; // 2:1

    void Start()
    {
        UpdateCamera();
    }

    void Update()
    {
        UpdateCamera(); // â ũ�� ���� �ø��� ���� ����
    }

    void UpdateCamera()
    {
        float windowAspect = (float)Screen.width / Screen.height;
        float scaleHeight = windowAspect / targetAspect;

        Camera cam = Camera.main;

        if (scaleHeight < 1.0f)
        {
            // â�� ���η� ������� ��/�Ʒ� ����
            Rect rect = new Rect(0, (1.0f - scaleHeight) / 2.0f, 1, scaleHeight);
            cam.rect = rect;
        }
        else
        {
            // â�� ���η� ������� ��/�� ����
            float scaleWidth = 1.0f / scaleHeight;
            Rect rect = new Rect((1.0f - scaleWidth) / 2.0f, 0, scaleWidth, 1);
            cam.rect = rect;
        }
    }
}

