using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomenemyspaw_script : MonoBehaviour
{

    public GameObject theEnemy;
    public int xPos;
    public int zPos;
    public int enemyCount;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemyDrop());
        
    }

    IEnumerator EnemyDrop()
    {


        xPos = Random.Range(1, 50);
        zPos = Random.Range(1, 31);
        Instantiate(theEnemy, new Vector3(xPos, 43, zPos), Quaternion.identity);
        yield return new WaitForSeconds(0.1f);
        enemyCount += 1;

    }





}
