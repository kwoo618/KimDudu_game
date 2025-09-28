using UnityEngine;
using TMPro;
using System.Collections;

public class TextFade : MonoBehaviour
{
    public TMP_Text text; // 페이드 인/아웃 할 텍스트
    public float fadeDuration = 1f; // 페이드 인/아웃 지속 시간

    void Start()
    {
        // 예제로 페이드 인/아웃을 호출합니다.
        StartCoroutine(FadeIn());
        Invoke("StartFadeOut", 3f); // 3초 후 페이드 아웃 시작
    }

    // 텍스트 페이드 인 함수
    public IEnumerator FadeIn()
    {
        float elapsedTime = 0f;
        Color textColor = text.color;
        textColor.a = 0f; // 시작할 때 텍스트가 투명하도록 설정
        text.color = textColor;

        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            textColor.a = Mathf.Clamp01(elapsedTime / fadeDuration); // 0에서 1 사이로 보간
            text.color = textColor;
            yield return null;
        }
    }

    // 텍스트 페이드 아웃 함수
    public IEnumerator FadeOut()
    {
        float elapsedTime = 0f;
        Color textColor = text.color;
        textColor.a = 1f; // 시작할 때 텍스트가 불투명하도록 설정
        text.color = textColor;

        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            textColor.a = Mathf.Clamp01(1 - (elapsedTime / fadeDuration)); // 1에서 0 사이로 보간
            text.color = textColor;
            yield return null;
        }
    }

    // 페이드 아웃을 시작하는 함수 (Invoke를 위한)
    void StartFadeOut()
    {
        StartCoroutine(FadeOut());
    }
}
