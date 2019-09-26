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
            Invoke("Restart", restartDelay);
            
        }

       
    }

    void Restart()
    {
        GameOverUI.SetActive(true);
        Player.SetActive(false);
    }
}
