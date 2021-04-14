using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePilot : MonoBehaviour
{
    public BaseController controller;
    public BaseShip ship;

    // Update is called once per frame
    void Update()
    {        
        ship.AddRotation(controller.directionalControl);
        HandleThrottle();
    }

    void HandleThrottle()
    {
        if (controller.btn1)
        {
            ship.ThrottleEngine(1);
        }
        else if (controller.btn2)
        {
            ship.ThrottleEngine(0);
        }
        else
        {
            ship.ThrottleEngine(0.5f);
        }
    }
}
