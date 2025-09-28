using System.Collections;
using UnityEngine;

public class EnemyShooter : MonoBehaviour
{
    public GameObject projectilePrefab; // 발사할 장애물 프리팹
    public Transform target; // 주인공의 Transform
    public float shootInterval = 3f; // 발사 간격
    public float projectileSpeed = 5f; // 장애물 속도

    private void Start()
    {
        StartCoroutine(ShootAtIntervals());
    }

    private IEnumerator ShootAtIntervals()
    {
        while (true)
        {
            yield return new WaitForSeconds(shootInterval);
            ShootProjectile();
        }
    }

    private void ShootProjectile()
    {
        if (target != null)
        {
            // 장애물 생성
            GameObject projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);

            // 장애물의 Rigidbody2D 가져오기
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                // 주인공을 향한 방향 벡터 계산
                Vector2 direction = (target.position - transform.position).normalized;

                // 장애물을 주인공 방향으로 발사
                rb.velocity = direction * projectileSpeed;
            }
        }
    }
}
