using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    [SerializeField] ParticleSystem _explosion;

    [SerializeField] PlayerController _playerController;
    [SerializeField] Transform _spawnerPos;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine(Explode());
            _explosion.Play();
            //collision.gameObject.SetActive(false);
        }
    }

    IEnumerator Explode()
    {

        yield return new WaitForSeconds(0.5f);
        _playerController.transform.position = _spawnerPos.position;
    }
}
