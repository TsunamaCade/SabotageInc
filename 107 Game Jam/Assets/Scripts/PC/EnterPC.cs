using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterPC : MonoBehaviour
{
    [SerializeField] private bool isOnPC;
    [SerializeField] private Camera pcCam, playerCam;
    [SerializeField] private Transform camLocation;
    [SerializeField] private GameObject pcUse;
    [SerializeField] private Move playerMove;

    [SerializeField] private GameObject enterText;
    private bool canEnter;

    [HideInInspector] public bool exitsPC;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void OnTriggerEnter(Collider player)
    {
        if(player.tag == "Player")
        {
            enterText.SetActive(true);
            canEnter = true;
        }
    }

    void OnTriggerExit(Collider player)
    {
        if(player.tag == "Player")
        {
            canEnter = false;
        }
    }

    void Update()
    {
        if(canEnter && !isOnPC && Input.GetButtonDown("Enter"))
        {
            canEnter = false;
            enterText.SetActive(false);
            StartCoroutine(Enter());
        }

        if(exitsPC || isOnPC && Input.GetButtonDown("Enter"))
        {
            exitsPC = false;
            StartCoroutine(Exit());
        }
    }

    private IEnumerator Enter()
    {
        playerMove.enabled = false;
        pcCam.transform.position = playerCam.transform.position;
        pcCam.transform.rotation = playerCam.transform.rotation;
        float elapsedTime = 0f;
        float duration = 1.5f;

        Vector3 initialPosition = pcCam.transform.position;
        Quaternion initialRotation = pcCam.transform.rotation;
        playerCam.enabled = false;
        pcCam.enabled = true;

        while (elapsedTime < duration)
        {
            pcCam.transform.position = Vector3.Lerp(initialPosition, camLocation.position, elapsedTime / duration);
            pcCam.transform.rotation = Quaternion.Lerp(initialRotation, camLocation.rotation, elapsedTime / duration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        pcCam.transform.position = camLocation.position;
        pcCam.transform.rotation = camLocation.rotation;
        isOnPC = true;
        pcUse.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
    }

    private IEnumerator Exit()
    {
        Cursor.lockState = CursorLockMode.Locked;
        pcUse.SetActive(false);
        float elapsedTime = 0f;
        float duration = 1.5f;

        Vector3 initialPosition = pcCam.transform.position;
        Quaternion initialRotation = pcCam.transform.rotation;

        while (elapsedTime < duration)
        {
            pcCam.transform.position = Vector3.Lerp(initialPosition, playerCam.transform.position, elapsedTime / duration);
            pcCam.transform.rotation = Quaternion.Lerp(initialRotation, playerCam.transform.rotation, elapsedTime / duration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        pcCam.transform.position = playerCam.transform.position;
        pcCam.transform.rotation = playerCam.transform.rotation;
        playerCam.enabled = true;
        pcCam.enabled = false;
        isOnPC = false;
        canEnter = true;
        playerMove.enabled = true;
    }
}
