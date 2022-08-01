using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextlevel_script : MonoBehaviour
{
    
    
    
    
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("exit level");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }






    }
}
