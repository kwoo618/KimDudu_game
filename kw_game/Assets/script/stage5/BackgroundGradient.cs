using UnityEngine;

public class BackgroundGradient : MonoBehaviour
{
    public Color startColor = Color.white; // 시작 색상
    public Color endColor = Color.red;     // 끝 색상
    public float duration = 5f;            // 색상이 변하는 데 걸리는 시간 (초)

    private SpriteRenderer spriteRenderer;
    private float timer = 0f;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer != null)
        {
            spriteRenderer.color = startColor; // 초기 색상 설정
        }
    }

    void Update()
    {
        if (spriteRenderer != null)
        {
            timer += Time.deltaTime / duration;
            spriteRenderer.color = Color.Lerp(startColor, endColor, Mathf.PingPong(timer, 1));
        }
    }
}
