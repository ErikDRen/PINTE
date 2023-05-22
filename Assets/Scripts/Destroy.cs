using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    [SerializeField] ParticleSystem _explosion;
    [SerializeField] Transform _spawnerPos;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            StartCoroutine(Explode(collision));
            _explosion.Play();
            //collision.gameObject.SetActive(false);
        }
    }

    IEnumerator Explode(Collision collision)
    {

        yield return new WaitForSeconds(0.5f);
        collision.transform.position = _spawnerPos.position;
    }
}
