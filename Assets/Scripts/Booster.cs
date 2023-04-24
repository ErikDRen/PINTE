using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booster : MonoBehaviour
{
    [SerializeField] PlayerController _playerController;
    private float initalSpeed = 0f;

    private void Start()
    {
        initalSpeed = _playerController.speed;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("HEEEEEEEEEEY");
        //_playerController.SetSpeed(_playerController.GetSpeed() * 1.5f);
        _playerController.speed *= 1.5f;
        StartCoroutine(BoostDuration());
    }

    IEnumerator BoostDuration()
    {
        yield return new WaitForSeconds(1.5f);
        _playerController.speed = initalSpeed;
    }
}

