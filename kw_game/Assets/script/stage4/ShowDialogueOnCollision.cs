using UnityEngine;

public class ShowDialogueOnCollision : MonoBehaviour
{
    public GameObject dialogueUI; // 대화 UI
    private bool isColliding = false; // 충돌 여부

    void OnTriggerEnter2D(Collider2D other)
    {
        // 충돌한 오브젝트가 플레이어인 경우
        if (other.CompareTag("Player"))
        {
            isColliding = true;
            dialogueUI.SetActive(true); // 대화 UI 활성화
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        // 충돌이 끝난 경우
        if (other.CompareTag("Player"))
        {
            isColliding = false;
            dialogueUI.SetActive(false); // 대화 UI 비활성화
        }
    }

    void Update()
    {
        // 플레이어와 충돌 중이고, 대화 UI가 활성화된 경우
        if (isColliding && dialogueUI.activeSelf)
        {
            // 예를 들어 '스페이스바'를 누르면 대화 UI를 닫을 수 있도록
            if (Input.GetKeyDown(KeyCode.Space))
            {
                dialogueUI.SetActive(false); // 대화 UI 비활성화
            }
        }
    }
}
