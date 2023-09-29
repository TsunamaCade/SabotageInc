using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToLocation : MonoBehaviour
{
    [SerializeField] private GameObject UI;
    [SerializeField] private GameObject player;
    [SerializeField] private Transform spawnAtHome;
    [SerializeField] private Transform spawnAtOffice;
    [SerializeField] private Transform spawnAtCafe;

    [SerializeField] private StoryInfo storyInfo;

    [SerializeField] private Camera homeCam, officeCam, cafeCam, cafeInside, alleyway;
    public void GoToHome()
    {
        Debug.Log("Home");
        player.transform.GetComponent<CharacterController>().enabled = false;
        player.transform.position = spawnAtHome.position;
        homeCam.enabled = true;
        officeCam.enabled = false;
        cafeCam.enabled = false;
        cafeInside.enabled = false;
        alleyway.enabled = false;
        player.transform.GetComponent<CharacterController>().enabled = true;
        UI.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;

        if(storyInfo.hasBox)
        {
            Destroy(UI);
            storyInfo.EndGame();
        }
    }

    public void GoToOffice()
    {
        Debug.Log("Office");
        player.transform.GetComponent<CharacterController>().enabled = false;
        player.transform.position = spawnAtOffice.position;
        homeCam.enabled = false;
        officeCam.enabled = true;
        cafeCam.enabled = false;
        cafeInside.enabled = false;
        alleyway.enabled = false;
        player.transform.GetComponent<CharacterController>().enabled = true;
        UI.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void GoToCafe()
    {
        Debug.Log("Cafe");
        player.transform.GetComponent<CharacterController>().enabled = false;
        player.transform.position = spawnAtCafe.position;
        homeCam.enabled = false;
        officeCam.enabled = false;
        cafeCam.enabled = true;
        cafeInside.enabled = false;
        alleyway.enabled = false;
        player.transform.GetComponent<CharacterController>().enabled = true;
        UI.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }
}
