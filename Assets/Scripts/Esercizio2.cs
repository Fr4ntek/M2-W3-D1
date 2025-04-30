using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio2 : MonoBehaviour
{
    public int dim;
    public int min;
    public int max;

    // Start is called before the first frame update
    void Start()
    {
        int[] array = GeneraArray(dim, min, max);
        StampaArray(array);
        Debug.Log("Il numero piu basso dell'array è: " + TrovaMinimo(array));
        Debug.Log("Il numero piu alto dell'array è: " + TrovaMassimo(array));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private int[] GeneraArray(int dim, int min, int max)
    {
        Debug.Log("GeneraArray: genero un array di dimensione " + dim + " con valori compresi" +
            " tra " + min + " e " + max);
        int[] array = new int[dim];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Random.Range(min, max);
        }
        Debug.Log("GeneraArray: fine");
        return array;
    }

    private void StampaArray(int[] array)
    {
        Debug.Log("StampaArray: stampo vettore generato dalla GeneraArray...");
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log("[" + array[i] + "]");
        }
    }

    private int TrovaMinimo(int[] array)
    {
        int min = array[0];
        Debug.Log("Cerco il numero piu basso nell'array passato...");
        for (int i = 1;i < array.Length; i++)
        {
            if(array[i] < min)
            {
                min = array[i];
            }
        }
        return min;
    }
    private int TrovaMassimo(int[] array)
    {
        int max = array[0];
        Debug.Log("Cerco il numero piu alto nell'array passato...");
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        return max;
    }
}
