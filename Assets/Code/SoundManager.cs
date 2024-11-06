using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SoundType
{
    bgm01,
    bgm02,
    bubble_pop,
    bubbles,
    catchs,
    complete,
    correct,
    fail,
    flip_card,
    first_aid,
    footstep,
    game_over,
    shuffle_card,
    suffle_cards,
    victory,
    water_sound,
    wrap,
    wrong
}

public class SoundManager : MonoBehaviour
{

   
    public static SoundManager Instance;

    public AudioSource audioSource,audioSource2;
    public AudioClip[] audioClips;


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Prevent destruction on scene load
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlaySoundBgm(SoundType soundType, bool Loop)
    {
        int index = (int)soundType;
        if (index >= 0 && index < audioClips.Length)
        {
            audioSource2.clip = audioClips[index];
            audioSource2.Play();
        }

        audioSource.loop = Loop;
    }

    public void PlaySound(SoundType soundType ,bool Loop)
    {
        int index = (int)soundType;
        if (index >= 0 && index < audioClips.Length)
        {
            audioSource.clip = audioClips[index];
            audioSource.Play();
        }

        audioSource.loop = Loop;

    }

    public void StopSound(SoundType soundType)
    {
        int index = (int)soundType;
        if (index >= 0 && index < audioClips.Length)
        {
            audioSource.Stop();
        }
    }
}

