using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;



public class CarController : MonoBehaviour
{
    public GameObject gameOverText, restartButton,mainMenu,gasButton,brakeButton,pauseButton,resumeButton,pausePanel ;
    public float fuel = 1;
    public float fuelconsumption = 0.1f;
    public Rigidbody2D Carcontroller;
    public Rigidbody2D backTire;
    public Rigidbody2D frontTire;
    public float speed = 20;
    public float cartorque = 10;
    private float movement;
    public UnityEngine.UI.Image image;
    // Start is called before the first frame update
    void Start()
    {
        gameOverText.SetActive(false);
        restartButton.SetActive(false);
        mainMenu.SetActive(false);
        resumeButton.SetActive(false);
        pausePanel.SetActive(false);
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        movement = CrossPlatformInputManager.GetAxisRaw("Horizontal");
        image.fillAmount = fuel;
    }

    private void FixedUpdate()
    {
        if (fuel > 0)
        {
            backTire.AddTorque(-movement * speed * Time.fixedDeltaTime);
            frontTire.AddTorque(-movement * speed * Time.fixedDeltaTime);
            Carcontroller.AddTorque(-movement * cartorque * Time.fixedDeltaTime);
            
        }
       else if(fuel<0)
        {
            Time.timeScale = 0f;
            gasButton.SetActive(false);
            brakeButton.SetActive(false);
            gameOverText.SetActive(true);
            restartButton.SetActive(true);
            mainMenu.SetActive(true);
            pauseButton.SetActive(false);
            pausePanel.SetActive(true);
        }
        fuel -= fuelconsumption * Mathf.Abs(movement) * Time.fixedDeltaTime;
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Finish")
        {
            Time.timeScale = 0f;
            gameOverText.SetActive(true);
            restartButton.SetActive(true);
            mainMenu.SetActive(true);
            gasButton.SetActive(false);
            brakeButton.SetActive(false);
            pauseButton.SetActive(false);
            pausePanel.SetActive(true);
        }
    }
}
