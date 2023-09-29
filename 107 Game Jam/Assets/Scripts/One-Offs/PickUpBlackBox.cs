using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PickUpBlackBox : MonoBehaviour
{
    [SerializeField] private StoryInfo storyInfo;
    [SerializeField] private TextMeshProUGUI grabText;

    void OnEnable()
    {
        storyInfo = GameObject.FindGameObjectWithTag("StoryInfo").transform.GetComponent<StoryInfo>();
        grabText = GameObject.FindGameObjectWithTag("Grab").GetComponentInChildren<TextMeshProUGUI>();
    }
    void OnTriggerStay(Collider player)
    {
        if(player.transform.tag == "Player")
        {
            grabText.enabled = true;
            if(Input.GetButtonDown("Enter"))
            {
                grabText.enabled = false;
                storyInfo.hasBox = true;
                Destroy(this.gameObject);
            }
        }
    }

    void OnTriggerExit(Collider player)
    {
        if(player.transform.tag == "Player")
        {
            grabText.enabled = false;
        }
    }
}
