using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booster : MonoBehaviour
{

    private float initalSpeed = 0f;

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("HEEEEEEEEEEY");
        //_playerController.SetSpeed(_playerController.GetSpeed() * 1.5f);
        initalSpeed = other.gameObject.GetComponent<PlayerController>().speed;
        other.gameObject.GetComponent<PlayerController>().speed *= 1.7f;
        StartCoroutine(BoostDuration(other));
    }

    IEnumerator BoostDuration(Collider other)
    {
        SpawnPlayer.Instance.PlayerInstance[0].GetComponent<PlayerController>().IsBoost = true;
        yield return new WaitForSeconds(1.5f);
        other.gameObject.GetComponent<PlayerController>().speed = initalSpeed;
        SpawnPlayer.Instance.PlayerInstance[0].GetComponent<PlayerController>().IsBoost = false;
    }
}

