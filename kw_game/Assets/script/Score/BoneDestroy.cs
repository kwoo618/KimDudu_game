using UnityEngine;

public class BoneDestroy : MonoBehaviour
{
    public string targetObjectName;
    public string DestroyName;
    public float fadeSpeed = 1.0f; // ������� �ӵ�

    private SpriteRenderer spriteRenderer;
    private bool fadingOut = false;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (fadingOut)
        {
            Color color = spriteRenderer.color;
            color.a -= fadeSpeed * Time.deltaTime; // ���� ���� ������ ����
            spriteRenderer.color = color;

            if (color.a <= 0)
            {
                Destroy(gameObject); // ���� ���� 0 �����̸� ������Ʈ�� �ı�
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == targetObjectName)
        {
            if (Scorebone.boneAmount >= 4)
            {
                fadingOut = true; // �� ��ũ��Ʈ�� �ִ� ������Ʈ�� ���̵�ƿ��ϵ��� ����
                Scorebone.boneAmount = 0;
                Destroy(GameObject.Find(DestroyName));
            }
            else
            {
                collision.gameObject.transform.position = Vector3.zero;
                HpUI2.hp -= 1;
            }
        }
    }
}
