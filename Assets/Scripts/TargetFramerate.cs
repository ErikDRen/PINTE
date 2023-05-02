using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetFramerate : MonoBehaviour
{
    void Start()
    {
        print($"current refresh rate = {Screen.currentResolution.refreshRate}");
        Application.targetFrameRate = Screen.currentResolution.refreshRate;
    }
}
