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
    }
}
