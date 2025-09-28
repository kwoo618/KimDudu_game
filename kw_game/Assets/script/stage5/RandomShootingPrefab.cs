using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomShootingPrefab : MonoBehaviour
{
    public GameObject projectilePrefab; // 발사할 장애물 프리팹
    public Transform target; // 주인공의 Transform
    public float intervalSec = 1f; // 발사 간격
    public float projectileSpeed = 5f; // 장애물 속도

    private void Start()
    {
        StartCoroutine(ShootAtIntervals());
    }

    private IEnumerator ShootAtIntervals()
    {
        while (true)
        {
            yield return new WaitForSeconds(intervalSec);
            CreateAndShootPrefab();
        }
    }

    private void CreateAndShootPrefab()
    {
        Vector3 area = GetComponent<SpriteRenderer>().bounds.size;

        Vector3 newPos = this.transform.position;
        newPos.x += Random.Range(-area.x / 2, area.x / 2);
        newPos.y += Random.Range(-area.y / 2, area.y / 2);
        newPos.z = -5;

        GameObject projectile = Instantiate(projectilePrefab, newPos, Quaternion.identity);

        // 주인공을 향한 방향 벡터 계산
        if (target != null)
        {
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                Vector2 direction = (target.position - newPos).normalized;
                rb.velocity = direction * projectileSpeed;
            }
        }
    }
}
