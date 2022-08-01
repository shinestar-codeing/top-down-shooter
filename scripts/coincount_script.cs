using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coincount_script : MonoBehaviour
{

    public int bank = 0;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void gotacoin()
    {
        bank = bank + 1;

    }
}
