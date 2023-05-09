using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{

    [SerializeField] Transform playerTrans;
    [SerializeField] Transform spwanTrans;

    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("AAAAAAAAAAAAaaaaaaaaaaaaaaaaa............");
        playerTrans.position = spwanTrans.position;
        playerTrans.rotation = spwanTrans.rotation;
    }
}
