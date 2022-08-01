using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectcoin_script : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("collected coin");
                Destroy(gameObject);
        }






    }
}
