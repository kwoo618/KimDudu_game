using System.Collections;
using UnityEngine;

public class EnemyThrowing : MonoBehaviour
{
    public GameObject projectilePrefab; // 던질 장애물 프리팹
    public Transform firePoint; // 장애물이 발사될 위치
    public float throwInterval = 2f; // 던지기 간격
    public float projectileSpeed = 10f; // 장애물 속도
    private Transform player; // 주인공의 Transform

    void Start()
    {
        // 주인공 오브젝트를 찾음
        player = GameObject.FindGameObjectWithTag("Player").transform;
        // 일정 간격으로 장애물을 던짐
        StartCoroutine(ThrowProjectile());
    }

    IEnumerator ThrowProjectile()
    {
        while (true)
        {
            yield return new WaitForSeconds(throwInterval);
            if (player != null)
            {
                Throw();
            }
        }
    }

    void Throw()
    {
        // 현재 적의 위치에서 주인공의 위치로 향하는 방향 계산
        Vector2 direction = (player.position - firePoint.position).normalized;
        // 장애물 생성
        GameObject projectile = Instantiate(projectilePrefab, firePoint.position, Quaternion.identity);
        // 장애물에 속도 부여
        Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
        rb.velocity = direction * projectileSpeed;

        // 디버그 로그 추가
        Debug.Log("Thrown projectile towards: " + player.position);
    }
}
