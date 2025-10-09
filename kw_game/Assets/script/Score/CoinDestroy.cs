using UnityEngine;

public class CoinDestroy : MonoBehaviour
{
    public string targetObjectName;
    public string DestroyName;
    public float fadeSpeed = 1.0f; // 사라지는 속도

    private SpriteRenderer spriteRenderer;
    private bool fadingOut = false;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (fadingOut)
        {
            Color color = spriteRenderer.color;
            color.a -= fadeSpeed * Time.deltaTime; // 알파 값을 서서히 줄임
            spriteRenderer.color = color;

            if (color.a <= 0)
            {
                Destroy(gameObject); // 알파 값이 0 이하이면 오브젝트를 파괴
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == targetObjectName)
        {
            if (Score.coinAmount == 5)
            {
                fadingOut = true; // 이 스크립트가 있는 오브젝트를 페이드아웃하도록 설정
                Score.coinAmount = 0; // 코인 개수를 0으로 설정
                Destroy(GameObject.Find(DestroyName));
            }
            else
            {
                collision.gameObject.transform.position = Vector3.zero;
                HpUI2.hp -= 1;
            }
        }
    }
}
