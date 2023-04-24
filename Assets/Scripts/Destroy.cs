using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    [SerializeField] ParticleSystem _explosion;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            print("hooray");
            _explosion.Play();
            //collision.gameObject.SetActive(false);


        }
    }
}
