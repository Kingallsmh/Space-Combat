using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseController : MonoBehaviour
{
    public Vector2 directionalControl;
    public bool btn1;
    public bool btn2;

    // Update is called once per frame
    void Update()
    {
        directionalControl = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        btn1 = Input.GetKey(KeyCode.Z);
        btn2 = Input.GetKey(KeyCode.X);
    }
}
