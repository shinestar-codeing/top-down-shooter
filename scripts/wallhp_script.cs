using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallhp_script : MonoBehaviour
{

    public float wallhp = 100;
    public float bulletdamage = 25;




    void OnCollisionEnter2D(Collision2D collision)


    {
        if (collision.gameObject.tag == "bullet")
        {


           Debug.Log("wall has been hit");
           wallhp = wallhp - bulletdamage;

            if (wallhp<1)
            {
                Destroy(gameObject);

            }




            

        }






    }
}

