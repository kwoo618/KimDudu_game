using UnityEngine;

public class C_sound : MonoBehaviour
{
    public AudioClip collisionSound; // �浹 ���� Ŭ��
    private AudioSource audioSource; // ���带 ����� AudioSource ������Ʈ

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void SoundPlay(AudioClip clip)
    {
        audioSource.PlayOneShot(clip); // �浹 ���� ���
    }

    private void OnCollisionEnter(Collision collision)
    {
        // �浹�� ������Ʈ�� �÷��̾����� �Ǵ� ��ֹ����� Ȯ��
        if (collision.gameObject.CompareTag("Player"))
        {
            // �浹 ���� ���
            SoundPlay(collisionSound);
        }
    }
}