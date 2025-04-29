using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio5 : MonoBehaviour
{
    public int find = 0;
    private int[] array = new int[10];

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Random.Range(find, 100);
            if (array[i] == find)
            {
                Debug.Log("Found");
            }
            else Debug.Log("Not Found - Valore elemento array: " + array[i]);
        }

        Debug.Log("Iterations finished");


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
