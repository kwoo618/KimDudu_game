using System.Collections;
using UnityEngine;

public class PopUp : MonoBehaviour
{
    public GameObject enemy; // 튀어나올 적 오브젝트
    public float popUpDelay = 0.5f; // 튀어나오는 딜레이 시간

    void Start()
    {
        // 적 오브젝트가 지정되지 않았을 경우, 동일한 오브젝트의 자식으로 설정
        if (enemy == null)
        {
            enemy = transform.Find("Enemy").gameObject;
        }

        // 적 오브젝트가 초기에는 비활성화되도록 설정
        enemy.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(PopUpEnemy());
        }
    }

    IEnumerator PopUpEnemy()
    {
        yield return new WaitForSeconds(popUpDelay);

        // 적 오브젝트 활성화 및 Sprite Renderer 활성화
        enemy.SetActive(true);
        enemy.GetComponent<SpriteRenderer>().enabled = true;
    }
}
