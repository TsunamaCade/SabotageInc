using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCAudio : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip walkOnCarpet, walkOnTile, type;

    public void PlayStepOnCarpet()
    {
        audioSource.PlayOneShot(walkOnCarpet);
    }
    public void PlayStepOnTile()
    {
        audioSource.PlayOneShot(walkOnTile);
    }
    public void PlayTyping()
    {
        audioSource.clip = type;
        audioSource.Play();
    }
}
