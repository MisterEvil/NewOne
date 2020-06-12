using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenu,restartButton, mainMenu,pauseButton, resumeButton, gasButton, brakeButton;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
   
   public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        restartButton.SetActive(false);
        mainMenu.SetActive(false);
        pauseButton.SetActive(true);
        resumeButton.SetActive(false);
        gasButton.SetActive(true);
        brakeButton.SetActive(true);
    }
    public void Pause()
    {
        pauseMenu.SetActive(true);

        Time.timeScale = 0f;
        GameIsPaused = true;
        restartButton.SetActive(true);
        mainMenu.SetActive(true);
        pauseButton.SetActive(false);
        resumeButton.SetActive(true);
        gasButton.SetActive(false);
        brakeButton.SetActive(false);
    }

}

