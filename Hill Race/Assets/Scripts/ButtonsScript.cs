using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsScript : MonoBehaviour
{
 
    public void restarScene1()
    {
        ScoreScript.scoreValue = 0;
        SceneManager.LoadScene("Infinite Level");
        Time.timeScale = 1f;
    }
    
    public void MainMenu() {
        SceneManager.LoadScene("MainMenu");
    }
    public void Quit()
    {
        Application.Quit();
    }
    }
