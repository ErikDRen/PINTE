using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class OutOfBounds : MonoBehaviour
{
    [SerializeField] Transform spwanTrans;
    PhotonView _view;
    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("AAAAAAAAAAAAaaaaaaaaaaaaaaaaa............");
        collision.transform.position = spwanTrans.position;
        collision.transform.rotation = spwanTrans.rotation;
    }
}
