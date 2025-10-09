using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bone : MonoBehaviour
{
    // �÷��̾� �±�
    public string playerTag = "Player";

    // Ʈ���� ���� �� ȣ��Ǵ� �Լ�
    private void OnTriggerEnter2D(Collider2D other)
    {
        // �浹�� ������Ʈ�� �÷��̾����� Ȯ��
        if (other.CompareTag(playerTag))
        {
            // �� ������ ȹ�� ó��
            Scorebone.boneAmount += 1;

            // �浹�� ������Ʈ�� ����
            Destroy(gameObject);
        }
    }
}