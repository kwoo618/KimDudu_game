using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FixedAspectRatio : MonoBehaviour
{
    // 원하는 비율
    public float targetAspect = 2f / 1f; // 2:1

    void Start()
    {
        UpdateCamera();
    }

    void Update()
    {
        UpdateCamera(); // 창 크기 변경 시마다 비율 유지
    }

    void UpdateCamera()
    {
        float windowAspect = (float)Screen.width / Screen.height;
        float scaleHeight = windowAspect / targetAspect;

        Camera cam = Camera.main;

        if (scaleHeight < 1.0f)
        {
            // 창이 세로로 길어지면 위/아래 블랙바
            Rect rect = new Rect(0, (1.0f - scaleHeight) / 2.0f, 1, scaleHeight);
            cam.rect = rect;
        }
        else
        {
            // 창이 가로로 길어지면 좌/우 블랙바
            float scaleWidth = 1.0f / scaleHeight;
            Rect rect = new Rect((1.0f - scaleWidth) / 2.0f, 0, scaleWidth, 1);
            cam.rect = rect;
        }
    }
}

