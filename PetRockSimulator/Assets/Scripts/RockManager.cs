using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockManager : MonoBehaviour
{
    [SerializeField]
    GameObject Rock;

    [SerializeField]
    TriggerArea raceTrigger;

    [SerializeField]
    TriggerArea runwayTrigger;

    




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckForRaceTrigger();
    }

    private void CheckForRaceTrigger()
    {
        if(raceTrigger.isEntered)
        {
            Rock.transform.position = raceTrigger.transform.position;
        }
    }
}
