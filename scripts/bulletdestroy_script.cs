using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletdestroy_script : MonoBehaviour
{
    public GameObject hitEffect;
    public float timeRemaining = 10;
    public bool timerIsRunning = false;

    void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(effect, 1f);
        Destroy(gameObject);
    }

    private void Start()
    {
        // Starts the timer automatically
        timerIsRunning = true;
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                Debug.Log("Time has run out!");

                timeRemaining = 0;
                timerIsRunning = false;
                GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
                Destroy(effect, 1f);
                Destroy(gameObject);
            }


        }
    }
}
