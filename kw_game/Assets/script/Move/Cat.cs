using UnityEngine;

public class Cat : MonoBehaviour
{
    public float speed = 2f;  // �̵� �ӵ�
    private Vector2 direction;  // �̵� ����
    private float changeDirectionTime = 1f;  // ���� ���� �ð� ����
    private float timer;  // Ÿ�̸�
    private bool isFacingRight = true;  // ���� ����̰� �������� ���ϰ� �ִ��� ����

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

        // ȭ�� ��� üũ �� �ݴ� �������� �̵�
        Vector3 position = transform.position;
        if (position.x < -10 || position.x > 10 || position.y < -5 || position.y > 5)
        {
            direction = -direction;
        }

        // ���⿡ ���� ��������Ʈ �ø�
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
                direction = Vector2.up;  // ����
                break;
            case 1:
                direction = Vector2.down;  // �Ʒ���
                break;
            case 2:
                direction = Vector2.left;  // ����
                break;
            case 3:
                direction = Vector2.right;  // ������
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
            // �÷��̾�� ���ظ� ������ �ڵ� �߰�
            Debug.Log("Cat hit the player!");
        }
        else
        {
            // �ٸ� ��ֹ��� �浹 �� ������ �ٲ�
            direction = -direction;
        }
    }
}