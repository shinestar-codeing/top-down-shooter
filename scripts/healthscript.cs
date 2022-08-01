using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthscript : MonoBehaviour
{
    public int healthpoints = 100;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(healthpoints<10)
        {

            Destroy(gameObject);


        }







    }

    void OnCollisionEnter2D(Collision2D collision)
    {



        healthpoints = healthpoints - 10;



    }
}
