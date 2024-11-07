using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConventionsAndSyntax : MonoBehaviour
{
    // Start is called before the first frame update

    private void Start()
    {
        //I want to get the x location of a game object and show it ojnh the console
        Debug.Log(transform.position.x);
    }

    // Update is called once per frame

    private void Update()
    {
        //I want to to know when a game object's y position is lower than 5
        if (transform.position.y <= 5f) 
        {
            Debug.Log("I'm about to hit the ground");
        }
    }    
}


    
