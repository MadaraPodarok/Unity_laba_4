using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;
using UnityEngine.SceneManagement;

public class EscapeMenuController : MonoBehaviour
{
    [SerializeField] private Canvas escapeMenuCanvas;
    [SerializeField] private Canvas dieCanvas;

    private bool pauseGame = false;

    private void Start()
    {
        escapeMenuCanvas.enabled = pauseGame;
        dieCanvas.enabled = false;
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            StateGame();
        }
    }

    public void StateGame()
    {
        if (dieCanvas.enabled)
        {
            return;
        }
        Debug.Log("PauseGameValue: " + pauseGame);
        if (pauseGame) 
        {
            Resume();
        }
        else
        {
            Pause();
        }
        pauseGame = !pauseGame;
        escapeMenuCanvas.enabled = pauseGame;
    }

    private void Resume()
    {
        Time.timeScale = 1;
        //Cursor.lockState = CursorLockMode.Locked;
        //Cursor.visible = false;
    }

    private void Pause()
    {
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
