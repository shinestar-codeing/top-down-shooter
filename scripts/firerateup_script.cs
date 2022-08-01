using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firerateup_script : MonoBehaviour
{
    public static float firerate;
    public float fireRAte;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("frirerateup");
            Destroy(gameObject);
            shooting_script.firerate = fireRAte;


            Debug.Log("the frierate is" +shooting_script.firerate);

        }






    }
}
