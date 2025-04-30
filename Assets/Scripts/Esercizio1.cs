using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio1 : MonoBehaviour
{
    public int number = 0;
    public int baseNumber = 0;
    public int multiple = 0;

    // Start is called before the first frame update
    void Start()
    {
        if (isEven(number))
        {
            Debug.Log("Il numero " + number + " è pari");
        } 
        else 
            Debug.Log("Il numero " + number + " è dispari");

        if(IsMultipleOf(baseNumber, multiple))
        {
            Debug.Log("Il numero " + multiple + " è multiplo del numero " + baseNumber);
        }
        else
            Debug.Log("Il numero " + multiple + " NON è multiplo del numero " + baseNumber);
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private bool isEven(int number)
    {
        if (number % 2 == 0)
        {
            return true;
        }
        else 
            return false;
    }

    private bool IsMultipleOf(int baseNumber, int multiple)
    {
        if(multiple % baseNumber == 0)
        {
            return true;
        } else
            return false;
    }

}
