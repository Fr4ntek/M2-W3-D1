using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio7 : MonoBehaviour
{
    public int min = 1;
    public int max = 100;
    // Start is called before the first frame update
    void Start()
    {
        int[] array = new int[20];
        GeneraArray(array, min, max);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GeneraArray(int[] array, int min, int max)
    {
        Debug.Log("GeneraArray: genero array con dati di input...");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Random.Range(min, max);
            Debug.Log("[" + array[i] + "]");
        }
        Debug.Log("GeneraArray: fine");
        
    }
}
