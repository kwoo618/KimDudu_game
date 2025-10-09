using UnityEngine;

public class Cat : MonoBehaviour
{
    public float speed = 2f;  // 이동 속도
    private Vector2 direction;  // 이동 방향
    private float changeDirectionTime = 1f;  // 방향 변경 시간 간격
    private float timer;  // 타이머
    private bool isFacingRight = true;  // 현재 고양이가 오른쪽을 향하고 있는지 여부

    void Start()
    {
        ChangeDirection();
        timer = changeDirectionTime;
    }

    void Update()
    {
        Move();
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            ChangeDirection();
            timer = changeDirectionTime;
        }
    }

    void Move()
    {
        transform.Translate(direction * speed * Time.deltaTime);

        // 화면 경계 체크 및 반대 방향으로 이동
        Vector3 position = transform.position;
        if (position.x < -10 || position.x > 10 || position.y < -5 || position.y > 5)
        {
            direction = -direction;
        }

        // 방향에 따라 스프라이트 플립
        if (direction == Vector2.left && isFacingRight)
        {
            Flip();
        }
        else if (direction == Vector2.right && !isFacingRight)
        {
            Flip();
        }
    }

    void ChangeDirection()
    {
        int randomDirection = Random.Range(0, 4);
        switch (randomDirection)
        {
            case 0:
                direction = Vector2.up;  // 위쪽
                break;
            case 1:
                direction = Vector2.down;  // 아래쪽
                break;
            case 2:
                direction = Vector2.left;  // 왼쪽
                break;
            case 3:
                direction = Vector2.right;  // 오른쪽
                break;
        }
    }

    void Flip()
    {
        isFacingRight = !isFacingRight;
        Vector3 localScale = transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // 플레이어에게 피해를 입히는 코드 추가
            Debug.Log("Cat hit the player!");
        }
        else
        {
            // 다른 장애물과 충돌 시 방향을 바꿈
            direction = -direction;
        }
    }
}