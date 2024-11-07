using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class VariablesandFunctions : MonoBehaviour
{
    //Create a variable of type integer
    int myInt = 3;


    // Start is called before the first frame update
    void Start()
    {
        //I am going to run my int thorugh my function to mulpitply it by two
        myInt = MultiplyByTwo(myInt);
        //Im going to print my results in the console
        Debug.Log(myInt);
    }

    // Update is called once per frame
    void Update()
    {
        //Creating a function that takes a int parameter and multiplies by 2    
    }
    int MultiplyByTwo(int number)
    {
        //Creating a variable to store my results
        int results;
        //multiplying the passed parameter by 2
        results = number * 2;

        //Returning the results 
        return results;
    }
}
