using System.Collections;
using UnityEngine;

public class BossShooter : MonoBehaviour
{
    public GameObject projectilePrefab; // �߻��� ��ֹ� ������
    public Transform target; // ���ΰ��� Transform
    public float shootInterval = 3f; // �߻� ����
    public float projectileSpeed = 5f; // ��ֹ� �ӵ�
    public bool shooting = false;

    private void Start()
    {
        // ��ũ��Ʈ�� �ʱ�ȭ�� �� ��ũ��Ʈ�� Ȱ��ȭ�Ǿ� �ִ��� ���θ� �����մϴ�.
        enabled = shooting;
        if (shooting)
        {
            StartCoroutine(ShootAtIntervals());
        }
    }

    // ��ũ��Ʈ�� Ȱ��ȭ�ϴ� �޼���
    public void ActivateShooting()
    {
        if (!enabled)
        {
            enabled = true;
            StartCoroutine(ShootAtIntervals());
        }
    }

    // ��ũ��Ʈ�� ��Ȱ��ȭ�ϴ� �޼���
    public void DeactivateShooting()
    {
        if (enabled)
        {
            StopCoroutine(ShootAtIntervals());
            enabled = false;
        }
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
            // ��ֹ� ����
            GameObject projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);

            // ��ֹ��� Rigidbody2D ��������
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                // ���ΰ��� ���� ���� ���� ���
                Vector2 direction = (target.position - transform.position).normalized;

                // ��ֹ��� ���ΰ� �������� �߻�
                rb.velocity = direction * projectileSpeed;
            }
        }
    }
}