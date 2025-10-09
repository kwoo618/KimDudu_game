using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CC_sound : MonoBehaviour
{
    static AudioSource audioSource;
    public static AudioClip[] audioClips; // ???? ?????? ?????? ?????? ????

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        LoadAudioClips(); // ?????? ???????? ????
    }

    // ?????? ???????? ???????? ????
    void LoadAudioClips()
    {
        // ?????? ???? ?????? ?????? ????????, ?? ???????? ?????? ?????? ?????? ??????????.
        audioClips = new AudioClip[20];
        audioClips[0] = Resources.Load<AudioClip>("ht");
        audioClips[1] = Resources.Load<AudioClip>("dog");
        audioClips[2] = Resources.Load<AudioClip>("key");
        audioClips[3] = Resources.Load<AudioClip>("car");
        audioClips[4] = Resources.Load<AudioClip>("99");
        audioClips[5] = Resources.Load<AudioClip>("banana");
        audioClips[6] = Resources.Load<AudioClip>("dg");
        audioClips[7] = Resources.Load<AudioClip>("gang");
        audioClips[8] = Resources.Load<AudioClip>("dam");
        audioClips[9] = Resources.Load<AudioClip>("water");
        audioClips[10] = Resources.Load<AudioClip>("poop");
        audioClips[11] = Resources.Load<AudioClip>("bone");
        audioClips[12] = Resources.Load<AudioClip>("cat");
        audioClips[13] = Resources.Load<AudioClip>("door");
        audioClips[14] = Resources.Load<AudioClip>("rock");
        audioClips[15] = Resources.Load<AudioClip>("attack");
        audioClips[16] = Resources.Load<AudioClip>("boom");
        audioClips[17] = Resources.Load<AudioClip>("box");
    }

    // ?????? ?????? ?????? ???????? ????
    public static void SoundPlay(int clipIndex)
    {
        if (clipIndex >= 0 && clipIndex < audioClips.Length)
        {
            audioSource.PlayOneShot(audioClips[clipIndex]);
        }
        else
        {
            Debug.LogWarning("Invalid clip index");
        }
    }
}