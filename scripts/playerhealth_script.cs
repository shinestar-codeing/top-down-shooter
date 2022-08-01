using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerhealth_script : MonoBehaviour
{
    public static int healthpoints = 100;
    public bool GameOver = false;
    public int Hp;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (healthpoints < 10)
        {

            Destroy(gameObject);
            FindObjectOfType<gameover_script>().EndGame();

        }

        Debug.Log(healthpoints);





    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            healthpoints = healthpoints - 10;
        }


        



    }






}

