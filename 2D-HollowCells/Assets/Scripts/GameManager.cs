using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;
    public float restartDelay = .1f;

    [SerializeField]
    private GameObject GameOverUI;
    [SerializeField]
    private GameObject Player;

    public void GameOver()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GameOver!");
            // start the methodname in x amount time seconds
            Invoke("Restart", restartDelay); // delay .1f
            
        }

       
    }

    void Restart()
    {
        GameOverUI.SetActive(true);
        Player.SetActive(false);
    }
}
