using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MovementUI : MonoBehaviour
{

    Movement _playerMovement; 
    private void Start()
    {
        _playerMovement = SpawnPlayer.Instance.PlayerInstance[0].GetComponent<Movement>();
    }

    public void GetTurnLeft(bool isPressed)
    {
        _playerMovement.UpdateTurnLeftBool(isPressed);
    }

    public void GetTurnRight(bool isPressed)
    {
        _playerMovement.UpdateTurnRightBool(isPressed);
    }

}
