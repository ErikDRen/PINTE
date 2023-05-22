using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerController : MonoBehaviour
{

    public bool IsBoost = false;
    public bool IsParked = false;
    public float speed = 10.0f;
    [SerializeField] Rigidbody _rb;

    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.Log(PhotonNetwork.CurrentRoom.Players.Count);
        if (IsParked == false && IsBoost == false)
        {
            if (PhotonNetwork.CurrentRoom.Players.Count < 4)
            {
                SpawnPlayer.Instance.PlayerInstance[0].GetComponent<PlayerController>().speed = 0;
                Debug.Log("vitesse 0");
            }
            else
            {
                SpawnPlayer.Instance.PlayerInstance[0].GetComponent<PlayerController>().speed = 10;
                Debug.Log("vitesse 10");
            } 
        }
        
        Vector3 speedY = transform.forward * speed;
        speedY.y = _rb.velocity.y;
        _rb.velocity = speedY; 
        //transform.Translate(Vector3.forward * Time.deltaTime * speed);

    }
}
