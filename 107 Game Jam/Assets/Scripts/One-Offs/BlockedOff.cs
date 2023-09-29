using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockedOff : MonoBehaviour
{
    [SerializeField] private GameObject blockedText;
    void OnTriggerStay(Collider player)
    {
        if(player.transform.tag == "Player")
        {
            blockedText.SetActive(true);
        }
    }

    void OnTriggerExit(Collider player)
    {
        if(player.transform.tag == "Player")
        {
            blockedText.SetActive(false);
        }
    }
}
