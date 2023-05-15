using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayer : MonoBehaviour
{
    [SerializeField] GameObject _playerPrefab;

    [SerializeField] float maxX;
    [SerializeField] float maxZ;
    [SerializeField] float minX;
    [SerializeField] float minZ;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 randomPosition = new Vector3( Random.Range(maxX, minX), 1.77f , Random.Range(maxZ, minZ));
        PhotonNetwork.Instantiate(_playerPrefab.name, randomPosition, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
