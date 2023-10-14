using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_Manager : MonoBehaviour
{
    public AudioSource audioSource;

    // Call this method to play the audio
    public void PlayAudio()
    {
        audioSource.Play();
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            PlayAudio();
        }
    }
}
