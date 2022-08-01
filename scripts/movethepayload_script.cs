using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movethepayload_script : MonoBehaviour
{
    public Rigidbody2D rb2D;
    public float thrust = 1f;




    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            Debug.Log("movieing the payload");
            rb2D.AddForce(transform.up * thrust);

        }






    }
}
