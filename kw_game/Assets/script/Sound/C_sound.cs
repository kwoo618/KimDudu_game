using UnityEngine;

public class C_sound : MonoBehaviour
{
    public AudioClip collisionSound; // 충돌 사운드 클립
    private AudioSource audioSource; // 사운드를 재생할 AudioSource 컴포넌트

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void SoundPlay(AudioClip clip)
    {
        audioSource.PlayOneShot(clip); // 충돌 사운드 재생
    }

    private void OnCollisionEnter(Collision collision)
    {
        // 충돌한 오브젝트가 플레이어인지 또는 장애물인지 확인
        if (collision.gameObject.CompareTag("Player"))
        {
            // 충돌 사운드 재생
            SoundPlay(collisionSound);
        }
    }
}