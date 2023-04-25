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
    void Start()
    {
        initalSpeed = _playerController.speed;
    }

    private void OnTriggerEnter(Collider other)
    {
        _playerController.speed = 0f;
        StartCoroutine(ValidatePark());
    }


    IEnumerator ValidatePark()
    {
        yield return new WaitForSeconds(1.5f);

        _boxCollider.gameObject.SetActive(false);
        _parkToValidate.gameObject.SetActive(false);
        validate.gameObject.SetActive(true);

        _playerController.transform.position = _spawnerPos.position;
        _playerController.transform.rotation = new Quaternion(0f, 0f, 0f , 0f);
        _playerController.speed = initalSpeed;
    }
}
