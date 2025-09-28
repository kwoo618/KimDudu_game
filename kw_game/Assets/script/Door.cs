using UnityEngine;

public class Door : MonoBehaviour
{
    private bool isOpen = false; // 문이 열려 있는지 여부
    public Animator animator; // 문 애니메이션을 제어할 애니메이터

    // 문을 여는 메소드
    public void OpenDoor()
    {
        if (!isOpen)
        {
            isOpen = true;
            animator.SetTrigger("Open"); // 애니메이션 트리거 설정
        }
    }
}
