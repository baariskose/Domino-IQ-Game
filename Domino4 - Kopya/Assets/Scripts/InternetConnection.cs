using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InternetConnection : MonoBehaviour
{
    public bool isConnected;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Application.internetReachability == NetworkReachability.ReachableViaCarrierDataNetwork || Application.internetReachability == NetworkReachability.ReachableViaLocalAreaNetwork)
        {

            isConnected = true;
           
        }
        else
        {
            isConnected = false;
        }
        


    }
}
