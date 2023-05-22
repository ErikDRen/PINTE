using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayer : MonoBehaviour
{

    [SerializeField] private GameObject _tuture;
    [SerializeField] private GameObject _camtar;
    [SerializeField] private GameObject _navion;

    private GameObject _playerPrefab;

    [SerializeField] float maxX;
    [SerializeField] float maxZ;
    [SerializeField] float minX;
    [SerializeField] float minZ;

    float iniatalSpeed = 0;
    PlayerController _playerController;

    PhotonView _view;
    public static SpawnPlayer Instance;
    public static Vector3 randomPosition;
    public List<GameObject> PlayerInstance;
    public int VehiculeType = 1;

    // Start is called before the first frame update

    private void Awake()
    {
        switch (VehiculeType)
        {
            case 1:
                _playerPrefab = _tuture;
                break;
            case 2:
                _playerPrefab = _navion;
                break;
            case 3:
                _playerPrefab = _camtar;
                break;
        }

        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        randomPosition = new Vector3(Random.Range(maxX, minX), 1.77f, Random.Range(maxZ, minZ));
        PlayerInstance = new List<GameObject>();
        PlayerInstance.Add(PhotonNetwork.Instantiate(_playerPrefab.name, randomPosition, Quaternion.identity));


    }
}    
