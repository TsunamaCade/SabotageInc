using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class StoryInfo : MonoBehaviour
{
    public bool hasKeycard = false;
    public bool hasUpgradedKeycard = false;
    public bool hasBox = false;

    [SerializeField] private GameObject barriers;
    [SerializeField] private GameObject rnDDoor;

    [SerializeField] private GameObject endGameScreen1;
    [SerializeField] private GameObject endGameScreen2;
    [SerializeField] private GameObject videoEnd;

    void Update()
    {
        if(hasKeycard)
        {
            UnlockBarriers();
            if(hasUpgradedKeycard)
            {
                UnlockDoor();
            }
        }
    }

    void UnlockBarriers()
    {
        Destroy(barriers);
    }

    void UnlockDoor()
    {
        Destroy(rnDDoor);
    }

    public void EndGame()
    {
        StartCoroutine(EndGameScreen());
    }

    IEnumerator EndGameScreen()
    {
        endGameScreen1.SetActive(true);
        yield return new WaitForSeconds(10f);
        endGameScreen2.SetActive(true);
        yield return new WaitForSeconds(5f);
        videoEnd.SetActive(true);
        yield return new WaitForSeconds(10f);
        Application.Quit();
    }
}
