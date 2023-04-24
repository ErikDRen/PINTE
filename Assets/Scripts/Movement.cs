using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public bool isTurningRight = false;
    public bool isTurningLeft = false;

    private void Update()
    {
        if (isTurningLeft == true)
        {
            transform.Rotate(0f, -1f, 0f);
        }

        if (isTurningRight == true)
        {
            transform.Rotate(0f, 1f, 0f);
        }
    }

    public void UpdateTurnRightBool()
    {
        isTurningRight = !isTurningRight;
    }
    
    public void UpdateTurnLeftBool()
    {
        isTurningLeft = !isTurningLeft;
    }
}
