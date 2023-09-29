using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] private GameObject gameOverScreen;

    void OnTriggerStay(Collider player)
    {
        if(player.transform.tag == "Player" && Input.GetButtonDown("Enter"))
        {
            StartCoroutine(Restart());
        }
    }

    IEnumerator Restart()
    {
        gameOverScreen.SetActive(true);
        yield return new WaitForSeconds(10f);
        Scene scene = SceneManager.GetActiveScene(); 
        SceneManager.LoadScene(scene.name);
    }
}
