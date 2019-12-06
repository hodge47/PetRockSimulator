using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PettingRock : MonoBehaviour
{
    /// <summary>
    /// This script checks if the mouse is over the rock and then if the player clicks they will start petting the rock
    /// the petting should spawn particles where the mouse collides
    /// </summary>

    RaycastHit mouseClickCheck;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray rayFromMouse = Camera.main.ScreenPointToRay(Input.mousePosition);

        }
        
        
    }
}
