using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToRnD : MonoBehaviour
{
    [SerializeField] private Transform rndSpawn;
    [SerializeField] private Camera rndCam, officeCam;
    void OnTriggerEnter(Collider player)
    {
        if(player.transform.tag == "Player")
        {
            player.transform.GetComponent<CharacterController>().enabled = false;
            player.transform.position = rndSpawn.position;
            rndCam.enabled = true;
            officeCam.enabled = false;
            player.transform.GetComponent<CharacterController>().enabled = true;
        }
    }
}
