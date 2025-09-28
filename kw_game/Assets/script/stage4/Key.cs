using UnityEngine;

public class Key : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // 플레이어에게 열쇠를 주는 함수 호출
            collision.GetComponent<PlayerController>().ObtainKey();

            // 열쇠 아이템 오브젝트를 비활성화
            gameObject.SetActive(false);
        }
    }
}
