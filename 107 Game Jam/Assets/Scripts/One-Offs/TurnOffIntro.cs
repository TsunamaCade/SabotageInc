using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffIntro : MonoBehaviour
{
    [SerializeField] private GameObject introScreen;
    void Start()
    {
        StartCoroutine(TurnOff());
    }

    IEnumerator TurnOff()
    {
        yield return new WaitForSeconds(10f);
        Destroy(introScreen);
    }
}
