using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PCUse : MonoBehaviour
{
    [SerializeField] private EnterPC enterPC;
    [SerializeField] private GameObject startUpScreen;
    [SerializeField] private GameObject screens;
    [SerializeField] private GameObject pages;
    [SerializeField] private GameObject home, listOfPeople, map;

    [SerializeField] private AudioSource audioSource;

    void Awake()
    {
        startUpScreen.transform.GetComponent<VideoPlayer>().loopPointReached += DisableScreen;
    }
    void DisableScreen(UnityEngine.Video.VideoPlayer vp)
    {
        startUpScreen.SetActive(false);
        screens.SetActive(true);
    }

    public void ExitPC()
    {
        enterPC.exitsPC = true;
    }

    public void OpenBrowser()
    {
        pages.SetActive(true);
    }

    public void CloseBrowser()
    {
        pages.SetActive(false);
    }

    public void OpenMenu()
    {
        home.SetActive(true);
        listOfPeople.SetActive(false);
        map.SetActive(false);
    }

    public void OpenList()
    {
        home.SetActive(false);
        listOfPeople.SetActive(true);
        map.SetActive(false);
    }

    public void OpenMap()
    {
        home.SetActive(false);
        listOfPeople.SetActive(false);
        map.SetActive(true);
    }

    public void PlaySound()
    {
        audioSource.Play();
    }
}