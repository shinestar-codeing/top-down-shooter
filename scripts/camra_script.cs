using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camra_script : MonoBehaviour
{

    //movement speed in units per second

    public Transform target;
    

    void Start()
    {
        target = GameObject.FindWithTag("Player").transform;

    }
    void Update()
    {


        transform.position = new Vector3(target.transform.position.x, target.transform.position.y, target.transform.position.z-100);
       
        


    }
}
