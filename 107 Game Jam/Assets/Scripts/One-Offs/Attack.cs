using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    [SerializeField] private GameObject target;
    [SerializeField] private GameObject keycard;
    [SerializeField] private GameObject killText;
    [SerializeField] private AudioSource audioSource;
    void OnTriggerStay(Collider player)
    {
        if(player.transform.tag == "Player")
        {
            killText.SetActive(true);
            if(Input.GetButtonDown("Enter"))
            {
                audioSource.Play();
                killText.SetActive(false);
                Instantiate(keycard);
                Destroy(target);
            }
        }
    }

    void OnTriggerExit(Collider player)
    {
        if(player.transform.tag == "Player")
        {
            killText.SetActive(false);
        }
    }
}
