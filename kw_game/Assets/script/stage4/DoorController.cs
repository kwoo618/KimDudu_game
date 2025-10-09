using System.Collections;
using UnityEngine;
using TMPro;

public class DoorController : MonoBehaviour
{
    public GameObject openDoorMessage; // "문이 열렸다" 메시지를 표시할 UI 텍스트
    public float messageDuration = 2f; // 메시지를 표시할 시간

    public void OpenDoor()
    {
        // 문 오브젝트를 비활성화
        gameObject.SetActive(false);
        Debug.Log("문이 열렸습니다!");

        // "문이 열렸다" 메시지를 표시하고 게임을 멈추는 코루틴 실행
        StartCoroutine(DisplayMessageAndPause());
    }

    private IEnumerator DisplayMessageAndPause()
    {
        // 메시지를 활성화하고 표시
        if (openDoorMessage != null)
        {
            openDoorMessage.SetActive(true);
        }
        else
        {
            Debug.LogError("OpenDoorMessage 오브젝트가 설정되지 않았습니다!");
        }

        // 시간을 멈춤
        Time.timeScale = 0f;

        // messageDuration 동안 기다림
        float pauseEndTime = Time.realtimeSinceStartup + messageDuration;
        while (Time.realtimeSinceStartup < pauseEndTime)
        {
            yield return null;
        }

        // 메시지를 비활성화하고 시간을 다시 진행
        if (openDoorMessage != null)
        {
            openDoorMessage.SetActive(false);
        }

        Time.timeScale = 1f;
    }
}
