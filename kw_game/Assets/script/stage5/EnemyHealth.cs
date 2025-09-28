using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 100; // 최대 체력
    private int currentHealth; // 현재 체력

    void Start()
    {
        currentHealth = maxHealth;
    }

    // 데미지를 받는 메서드
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    // 체력이 0이 되었을 때 호출되는 메서드
    private void Die()
    {
        Destroy(gameObject); // 적 오브젝트를 파괴
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
        {
            TakeDamage(10); // 투사체와 충돌 시 데미지 받음
            Destroy(collision.gameObject); // 투사체를 파괴
        }
    }
}
