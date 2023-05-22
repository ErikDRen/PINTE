using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UIElements;

public class Park : MonoBehaviour
{



    private float initalSpeed = 0f;


    [SerializeField] BoxCollider _boxCollider;
    [SerializeField] Canvas _parkToValidate;
    [SerializeField] Canvas validate;
    /**/

    [SerializeField] Transform _spawnerPos;

    PhotonView _view;


    PlayerController _playerController;

    // Start is called before the first frame update
    private void Start()
    {
        _view = SpawnPlayer.Instance.PlayerInstance[0].GetComponent<PhotonView>(); ;
        _playerController = SpawnPlayer.Instance.PlayerInstance[0].GetComponent<PlayerController>();
    }

    private void OnTriggerEnter(Collider other)
    {

        //Debug.Log("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAa");
        if (_view.IsMine)
        {
            initalSpeed = _playerController.speed;
            _playerController.speed = 0;
            StartCoroutine(ValidatePark(other));
        }

    }


    IEnumerator ValidatePark(Collider other)
    {
        yield return new WaitForSeconds(1.5f);

        _boxCollider.gameObject.SetActive(false);
        _parkToValidate.gameObject.SetActive(false);
        validate.gameObject.SetActive(true);


        other.transform.position = _spawnerPos.position;
        other.transform.rotation = new Quaternion(0f, 0f, 0f , 0f);
        _playerController.speed = initalSpeed;
    }
}
