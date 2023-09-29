using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentSounds : MonoBehaviour
{
    [SerializeField] private Camera cam;
    [SerializeField] private AudioSource audioSource;

    void Update()
    {
        if(cam.enabled)
        {
            StartCoroutine(PlaySound());
        }
        else
        {
            audioSource.Stop();
        }
    }

    IEnumerator PlaySound()
    {
        if(audioSource.isPlaying)
        {
            yield return null;
        }
        else
        {
            audioSource.Play();
            yield return new WaitForSeconds(audioSource.clip.length);
        }
    }
}
