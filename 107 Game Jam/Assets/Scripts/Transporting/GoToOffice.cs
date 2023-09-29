using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToOffice : MonoBehaviour
{
    [SerializeField] private Transform officeSpawn;
    [SerializeField] private Camera cubicalCam, officeCam;
    void OnTriggerEnter(Collider player)
    {
        if(player.transform.tag == "Player")
        {
            player.transform.GetComponent<CharacterController>().enabled = false;
            player.transform.position = officeSpawn.position;
            cubicalCam.enabled = false;
            officeCam.enabled = true;
            player.transform.GetComponent<CharacterController>().enabled = true;
        }
    }
}
