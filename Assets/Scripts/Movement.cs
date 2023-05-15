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
            if (isTurningLeft == true)
            {
                transform.Rotate(0f, -(_turningSpeed * Time.deltaTime), 0f);
            }

            if (isTurningRight == true)
            {
                transform.Rotate(0f, _turningSpeed * Time.deltaTime, 0f);
            }
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
