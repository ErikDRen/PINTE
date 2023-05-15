using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerController : MonoBehaviour
{

    public float speed = 10.0f;
    [SerializeField] Rigidbody _rb;


    // Update is called once per frame
    void FixedUpdate()
    {

            Vector3 speedY = transform.forward * speed;
            speedY.y = _rb.velocity.y;
            _rb.velocity = speedY;
            //transform.Translate(Vector3.forward * Time.deltaTime * speed);

    }
}
