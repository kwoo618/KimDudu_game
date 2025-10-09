using UnityEngine;
using System.Collections;

public class CameraIntro : MonoBehaviour
{
    public Transform player;       // 주인공 위치
    public Transform destination;  // 목적지 위치
    public float showDuration = 3.0f; // 목적지를 보여주는 시간
    public float moveSpeed = 2.0f; // 카메라 이동 속도

    private void Start()
    {
        StartCoroutine(ShowDestinationThenMoveToPlayer());
    }

    private IEnumerator ShowDestinationThenMoveToPlayer()
    {
        // 1. 목적지 위치로 카메라 이동
        transform.position = new Vector3(destination.position.x, destination.position.y, transform.position.z);

        // 2. 일정 시간 동안 대기
        yield return new WaitForSeconds(showDuration);

        // 3. 주인공으로 카메라 이동 시작
        while (Vector3.Distance(transform.position, player.position) > 0.1f)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(player.position.x, player.position.y, transform.position.z), moveSpeed * Time.deltaTime);
            yield return null;
        }

        // 정확하게 주인공 위치로 맞추기
        transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
    }
}
