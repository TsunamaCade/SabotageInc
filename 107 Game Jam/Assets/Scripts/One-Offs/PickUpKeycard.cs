using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PickUpKeycard : MonoBehaviour
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
                storyInfo.hasKeycard = true;
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
