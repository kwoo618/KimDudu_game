using System.Collections;
using UnityEngine;

public class TelpoC : MonoBehaviour
{
    private Vector3 startPosition; // 시작 위치
    public float fadeDuration = 0.5f; // 페이드 인/아웃 지속 시간

    private void Start()
    {
        // 현재 위치를 시작 위치로 저장
        startPosition = transform.position;
    }

    // 충돌 감지 메서드
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Obstacle")) // "Obstacle" 태그가 있는 오브젝트와 충돌할 경우
        {
            StartCoroutine(TeleportCoroutine()); // 텔레포트 코루틴 시작
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Obstacle")) // "Obstacle" 태그가 있는 오브젝트와 충돌할 경우
        {
            StartCoroutine(TeleportCoroutine()); // 텔레포트 코루틴 시작
        }
    }

    // 페이드 아웃 및 순간 이동 코루틴
    private IEnumerator TeleportCoroutine()
    {
        // 페이드 아웃
        float elapsedTime = 0f;
        while (elapsedTime < fadeDuration)
        {
            float alpha = Mathf.Lerp(1f, 0f, elapsedTime / fadeDuration);
            Color newColor = new Color(1f, 1f, 1f, alpha);
            GetComponent<SpriteRenderer>().color = newColor;
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // 시작 위치로 순간 이동
        transform.position = startPosition;

        // 페이드 인
        elapsedTime = 0f;
        while (elapsedTime < fadeDuration)
        {
            float alpha = Mathf.Lerp(0f, 1f, elapsedTime / fadeDuration);
            Color newColor = new Color(1f, 1f, 1f, alpha);
            GetComponent<SpriteRenderer>().color = newColor;
            elapsedTime += Time.deltaTime;
            yield return null;
        }
    }
}