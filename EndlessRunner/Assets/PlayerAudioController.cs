using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudioController : MonoBehaviour
{
    [SerializeField] public AudioSource playerHurtAudioSource;
    [SerializeField] private AudioClip[] hurtAudioClips;

    public void PlayCollisionAudio()
    {
        int audioIndex = Random.Range(0, hurtAudioClips.Length);
        playerHurtAudioSource.clip = hurtAudioClips[0];
        playerHurtAudioSource.Play();
    }
}
