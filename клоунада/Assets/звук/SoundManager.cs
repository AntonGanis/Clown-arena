using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip sound;

    void Update()
    {
        bool ere = true;
        if (ere)
        {
            PlaySound();
        }
    }

    void PlaySound()
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(sound);
    }
}