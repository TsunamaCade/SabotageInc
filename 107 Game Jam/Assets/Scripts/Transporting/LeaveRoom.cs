using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaveRoom : MonoBehaviour
{
    [SerializeField] private GameObject UI;
    void OnTriggerEnter(Collider player)
    {
        if(player.transform.tag == "Player")
        {
            UI.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }
    }

    void OnTriggerExit(Collider player)
    {
        if(player.transform.tag == "Player")
        {
            UI.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
