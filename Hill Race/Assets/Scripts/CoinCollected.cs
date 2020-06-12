using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollected : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")
        {
            ScoreScript.scoreValue += 100;
            Destroy(gameObject);
        }
    }
}
