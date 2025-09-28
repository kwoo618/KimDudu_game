using UnityEngine;

public class ClickAndFade : MonoBehaviour
{
    public float fadeDuration = 1f; // 사라지는 데 걸리는 시간

    private bool isInteracting = false; // 상호작용 중인지 여부
    private float startTime; // 상호작용 시작 시간
    private SpriteRenderer objectRenderer; // 오브젝트의 SpriteRenderer 컴포넌트

    void Start()
    {
        objectRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // 마우스 왼쪽 버튼이 눌렸는지 확인
        if (Input.GetMouseButtonDown(0))
        {
            // 클릭된 위치에서 Ray를 발사하여 충돌된 오브젝트 확인
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

            // Ray가 충돌한 오브젝트가 있고, 그 오브젝트가 이 스크립트가 붙어있는 오브젝트와 같은 경우
            if (hit.collider != null && hit.collider.gameObject == gameObject)
            {
                // 상호작용 시작
                StartInteraction();
            }
        }

        // 상호작용 중일 때
        if (isInteracting)
        {
            // 투명도 감소
            float timeRatio = (Time.time - startTime) / fadeDuration;
            Color newColor = objectRenderer.color;
            newColor.a = Mathf.Lerp(1f, 0f, timeRatio);
            objectRenderer.color = newColor;

            // 투명도가 0 이하가 되면 오브젝트 비활성화
            if (timeRatio >= 1f)
            {
                gameObject.SetActive(false);
            }
        }
    }

    // 상호작용 시작 함수
    void StartInteraction()
    {
        isInteracting = true;
        startTime = Time.time;
    }
}
