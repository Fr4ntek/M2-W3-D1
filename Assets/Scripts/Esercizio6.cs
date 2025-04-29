using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] array = GeneraArray();
        SommaArray();
        StampaArray(array);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int[] GeneraArray()
    {
        Debug.Log("GeneraArray: genero il primo array...");
        int[] array = new int[20];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Random.Range(1, 101);
        }
        Debug.Log("GeneraArray: fine");
        return array;
    }

    public void SommaArray()
    {
        Debug.Log("SommaArray: genero il secondo array e calcolo la somma...");
        int[] array = new int[20];
        int somma = 0;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Random.Range(1, 101);
            Debug.Log("[" + array[i] + "]");
            somma += array[i];
        }
        Debug.Log("Somma: " + somma);
    }

    public void StampaArray(int[] array)
    {
        Debug.Log("StampaArray: stampo vettore generato dalla GeneraArray passato in input...");
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log("[" + array[i] + "]");
        }
    }


}
