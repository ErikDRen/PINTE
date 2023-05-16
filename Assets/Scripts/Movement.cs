using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Movement : MonoBehaviour
{
    public bool isTurningRight = false;
    public bool isTurningLeft = false;

    PhotonView _view;

    [SerializeField] private float _turningSpeed = 100f;

    private void Start()
    {
        _view = GetComponent<PhotonView>();
    }
    private void Update()
    {
        if (_view.IsMine) {
            Debug.Log("Here");
            if (isTurningLeft == true)
            {
                Debug.Log("de dans l");
                transform.Rotate(0f, -(_turningSpeed * Time.deltaTime), 0f);
            }

            if (isTurningRight == true)
            {
                Debug.Log("de dans r");
                transform.Rotate(0f, _turningSpeed * Time.deltaTime, 0f);
            }
        }

    }

    public void UpdateTurnRightBool(bool isDown)
    {
        Debug.Log("dehors");
        isTurningRight = isDown;
        Debug.Log(isTurningRight + "right");
    }
    
    public void UpdateTurnLeftBool(bool isDown)
    {
        isTurningLeft = isDown;
        Debug.Log(isTurningLeft + "left");
    }
}
