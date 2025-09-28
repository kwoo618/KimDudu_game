using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private bool hasKey = false; // 플레이어가 열쇠를 가지고 있는지 여부

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Door"))
        {
            DoorController doorController = other.GetComponent<DoorController>();
            if (doorController != null && hasKey)
            {
                doorController.OpenDoor();
            }
        }
    }

    // 플레이어가 열쇠를 획득할 때 호출되는 메서드
    public void ObtainKey()
    {
        hasKey = true;
        Debug.Log("플레이어가 열쇠를 획득했습니다!");
    }

    // 플레이어가 열쇠를 가지고 있는지 여부를 반환하는 메서드
    public bool HasKey()
    {
        return hasKey;
    }
}
