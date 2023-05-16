using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Park : MonoBehaviour
{

    [SerializeField] PlayerController _playerController;
    private float initalSpeed = 0f;
    [SerializeField] Transform _spawnerPos;
    [SerializeField] BoxCollider _boxCollider;
    [SerializeField] Canvas _parkToValidate;
    [SerializeField] Canvas validate;

    // Start is called before the first frame update


    private void OnTriggerEnter(Collider other)
    {
        initalSpeed = other.gameObject.GetComponent<PlayerController>().speed;
        other.gameObject.GetComponent<PlayerController>().speed = 0;
        StartCoroutine(ValidatePark(other));
    }


    IEnumerator ValidatePark(Collider other)
    {
        yield return new WaitForSeconds(1.5f);

        _boxCollider.gameObject.SetActive(false);
        _parkToValidate.gameObject.SetActive(false);
        validate.gameObject.SetActive(true);


        other.transform.position = _spawnerPos.position;
        other.transform.rotation = new Quaternion(0f, 0f, 0f , 0f);
        other.gameObject.GetComponent<PlayerController>().speed = initalSpeed;
    }
}
