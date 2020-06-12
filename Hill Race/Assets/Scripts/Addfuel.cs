using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addfuel : MonoBehaviour
{
    public CarController carController;

    /*private void Awake() {

        carController = GetComponent<CarController>();
    } */

    /*private GameObject carController;
    private void Update() {

        carController = GameObject.Find("Player");
       carController = GetComponent<CarController>();
    }*/

   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        carController.fuel = 1;
        Destroy(gameObject);
        
    }
}
