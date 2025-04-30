using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio3 : MonoBehaviour
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
        TrovaMinimi2(array);
        TrovaMassimi2(array);
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
        int min = int.MaxValue;
        Debug.Log("Cerco il numero piu basso nell'array...");
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }
        return min;
    }
    private int TrovaMassimo(int[] array)
    {
        int max = int.MinValue;
        Debug.Log("Cerco il numero piu alto nell'array...");
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        return max;
    }

    private void TrovaMinimi2(int[] array)
    {
        int min1 = int.MaxValue;
        int min2 = int.MaxValue;
        Debug.Log("Cerco i 2 numeri piu bassi nell'array...");
        for(int i = 0; i < array.Length; i++)
        {
            if(array[i] < min1)
            {
                min2 = min1;
                min1 = array[i];
            }
            else if(array[i] < min2)
            {
                min2 = array[i];
            }
        }

        Debug.Log("I 2 numeri piu bassi dell array sono: " +  min1 + " e " + min2);
    }
    private void TrovaMassimi2(int[] array)
    {
        int max1 = int.MinValue;
        int max2 = int.MinValue;
        Debug.Log("Cerco i 2 numeri piu alti nell'array...");
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max1)
            {
                max2 = max1;
                max1 = array[i];
            }
            else if (array[i] > max2)
            {
                max2 = array[i];
            }
        }
        Debug.Log("I 2 numeri piu alti dell array sono: " + max1 + " e " + max2);
    }
}
