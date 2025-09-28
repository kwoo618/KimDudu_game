using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private bool playerHasKey = false; // 플레이어가 열쇠를 가지고 있는지 여부

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // 플레이어가 열쇠를 얻었을 때 호출되는 메서드
    public void PlayerObtainedKey()
    {
        playerHasKey = true;
    }

    // 플레이어가 열쇠를 가지고 있는지 여부를 반환하는 메서드
    public bool PlayerHasKey()
    {
        return playerHasKey;
    }
}
