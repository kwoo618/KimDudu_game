using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bone : MonoBehaviour
{
    // 플레이어 태그
    public string playerTag = "Player";

    // 트리거 진입 시 호출되는 함수
    private void OnTriggerEnter2D(Collider2D other)
    {
        // 충돌한 오브젝트가 플레이어인지 확인
        if (other.CompareTag(playerTag))
        {
            // 뼈 아이템 획득 처리
            Scorebone.boneAmount += 1;

            // 충돌한 오브젝트를 삭제
            Destroy(gameObject);
        }
    }
}