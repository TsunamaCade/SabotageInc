using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToCubicals : MonoBehaviour
{
    [SerializeField] private Transform cubicalSpawn;
    [SerializeField] private Camera cubicalCam, officeCam;
    void OnTriggerEnter(Collider player)
    {
        if(player.transform.tag == "Player")
        {
            player.transform.GetComponent<CharacterController>().enabled = false;
            player.transform.position = cubicalSpawn.position;
            cubicalCam.enabled = true;
            officeCam.enabled = false;
            player.transform.GetComponent<CharacterController>().enabled = true;
        }
    }
}
