using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    [SerializeField] private Camera cam;
    void OnTriggerEnter(Collider player)
    {
        if(player.transform.tag == "Player")
        {
            cam.enabled = true;
        }
    }

    void OnTriggerExit(Collider player)
    {
        if(player.transform.tag == "Player")
        {
            cam.enabled = false;
        }
    }
}
