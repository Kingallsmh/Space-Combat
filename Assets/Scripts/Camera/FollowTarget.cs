using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float distance = 5.0f;
    [SerializeField] float height = 4.0f;

    [SerializeField] float followDampen = 6.0f;


    void FixedUpdate()
    {
        if (!target)
            return;

        Vector3 wantedPosition = target.position + (-target.forward * distance) + (target.up * height);
        transform.position = Vector3.Lerp(transform.position, wantedPosition, followDampen * Time.deltaTime);

        transform.rotation = target.rotation;

        //transform.position += transform.up * height;
    }
}
