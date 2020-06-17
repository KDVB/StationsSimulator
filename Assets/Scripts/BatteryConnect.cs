using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryConnect : MonoBehaviour
{
    public GameObject station;
    public bool connect = false;

    public void Connect()
    {
        if(!connect)
        {
            station.GetComponent<Animation>().PlayQueued("PositionToBatteryConnect", QueueMode.CompleteOthers);
            connect = true;
        }
        else 
        {
            station.GetComponent<Animation>().PlayQueued("PositionAfterBatteryConnect", QueueMode.CompleteOthers);
            connect = false;
        }
    }
}
