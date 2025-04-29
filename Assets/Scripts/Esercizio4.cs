using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio4 : MonoBehaviour
{
    public int start = 0;
    public int amount = 0;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i <= amount; i++)
        {
            Debug.Log(start + i);
        } 

        
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
