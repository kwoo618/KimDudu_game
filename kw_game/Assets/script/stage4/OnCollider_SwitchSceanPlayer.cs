using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnCollision_SwitchScenePlayer : MonoBehaviour
{

    public string playerTag; // 플레이어의 태그
    public string sceneName; // 전환할 씬의 이름

    // OnCollisionEnter2D 함수는 충돌이 시작될 때 호출됩니다.
    void OnCollisionEnter2D(Collision2D collision)
    {
        // 충돌한 객체가 플레이어인지 확인합니다.
        if (collision.gameObject.CompareTag(playerTag))
        {
            // 씬을 전환합니다.
            SceneManager.LoadScene(sceneName);
        }
    }
}
