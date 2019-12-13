using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerArea : MonoBehaviour
{
    public bool isEntered = false;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Rock"))
        {
            isEntered = true;
            Debug.Log("rock has entered the trigger area");
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Rock"))
        {
            isEntered = false;
            Debug.Log("rock has left the trigger area");
        }
    }
}
