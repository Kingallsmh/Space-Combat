using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseShip : MonoBehaviour
{
    public Rigidbody rb;

    public bool engineIsOn = true;
    public Vector2 engineRange = new Vector2(0, 1);
    public float accelAmount = 1;
    public Vector2 rotationSpeeds = new Vector2(1, 1);
    public float rotLerpAmount = 0.1f;

    Vector3 wantedRotation;
    Vector3 currentRot;
    float speedWanted;
    float currentSpeed;

    private void FixedUpdate()
    {
        RotateShip();
        EngineUpdate();
    }

    void EngineUpdate()
    {        
        if (engineIsOn)
        {
            currentSpeed = Mathf.Lerp(currentSpeed, speedWanted, accelAmount);
            rb.velocity = transform.forward * (currentSpeed);
        }
    }

    void RotateShip()
    {
        currentRot = Vector3.Lerp(currentRot, wantedRotation, rotLerpAmount);
        transform.Rotate(currentRot);
    }

    public void AddRotation(Vector3 rot)
    {
        wantedRotation = new Vector3(rot.y * rotationSpeeds.y, 0, -rot.x * rotationSpeeds.x);
    }

    public void ThrottleEngine(float throttlePos)
    {
        speedWanted = Mathf.Lerp(engineRange.x, engineRange.y, throttlePos);        
    }
}
