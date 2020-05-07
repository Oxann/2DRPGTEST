using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartSFXTrigger : MonoBehaviour
{
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(!audioSource.isPlaying) audioSource.Play();
    }
}
