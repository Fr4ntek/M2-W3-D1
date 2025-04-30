using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Esercizio4 : MonoBehaviour
{
    public int dim;
    public int min;
    public int max;
    public int newDim;

    // Start is called before the first frame update
    void Start()
    {
        int[] array = GeneraArray(dim, min, max);
        int[] nuovoArray = CambiaDimensioneArray(array, newDim);
        StampaArray(nuovoArray);
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
            array[i] = Random.Range(min, max + 1);
            Debug.Log("[" + array[i] + "]");
        }
        Debug.Log("GeneraArray: fine");
        return array;
    }

    private int[] CambiaDimensioneArray(int[] arr, int newDim)
    {
        Debug.Log("CambiaDimensioneArray: inizio...");
        int[] nuovoArray = null;
        if (newDim < arr.Length)
        {
            Debug.Log("La nuova dimensione è minore: " + newDim + " quindi copierò solo i primi " +
                newDim + " elementi del veccio array");
            nuovoArray = new int[newDim];
            for(int i = 0;i < nuovoArray.Length; i++)
            {
                nuovoArray[i] = arr[i];
            }
        }

        if(newDim > arr.Length)
        {
            Debug.Log("La nuova dimensione è maggiore: " + newDim + " quindi aggiungerò " + 
                (newDim-arr.Length) + " zero/i");
            nuovoArray = new int[newDim];
            for (int i = 0; i < arr.Length; i++)
            {
                nuovoArray[i] = arr[i];
            }
            for (int j = arr.Length; j < nuovoArray.Length; j++)
            {
                nuovoArray[j] = 0;
            } 
        }

        if(newDim == arr.Length)
        {
            Debug.Log("Le dimensioni sono uguali, restituisco il vecchio array");
            nuovoArray = arr;
        }

        return nuovoArray;
    }

    private void StampaArray(int[] array)
    {
        Debug.Log("Il nuovo array è: ");
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log("[" + array[i] + "]");
        }
    }
}
