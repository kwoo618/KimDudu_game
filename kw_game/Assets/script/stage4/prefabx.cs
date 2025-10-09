using UnityEngine;

public class prefabx : MonoBehaviour
{
    public GameObject newPrefab;
    public float intervalSec = 1;
    public float distance = 1f; // 생성 거리

    void Start()
    {
        InvokeRepeating("CreatePrefab", intervalSec, intervalSec);
    }

    void CreatePrefab()
    {
        // 현재 오브젝트의 전방 방향 벡터를 구함
        Vector3 forwardVector = transform.forward;

        // 현재 오브젝트의 위치에서 전방 방향 벡터와 거리를 곱하여 새로운 위치를 계산
        Vector3 newPos = transform.position + forwardVector * distance;

        // 새로운 프리팹을 생성
        GameObject newGameObject = Instantiate(newPrefab, newPos, Quaternion.identity);
    }
}
