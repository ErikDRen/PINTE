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

    PhotonView _view;
    public static SpawnPlayer Instance;
    public static Vector3 randomPosition;
    public List<GameObject> PlayerInstance;
    public int VehiculeType = 1;

    // Start is called before the first frame update
    void Start()
    {
        /*_view = GetComponent<PhotonView>();
        if (!_view.IsMine)
        {
            SpawnPlayer.Instance.GetComponent<Rigidbody>().useGravity = false;
            SpawnPlayer.Instance.GetComponent<PlayerController>().enabled = false;
            SpawnPlayer.Instance.GetComponent<Movement>().enabled = false;
            SpawnPlayer.Instance.GetComponent<Camera>().enabled = false;

        }*/
    }

    private void Awake()
    {
        switch (VehiculeType)
        {
            case 1 :
                _playerPrefab = _tuture;
                break;
            case 2 :
                _playerPrefab = _camtar;
                break;
            case 3 :
                _playerPrefab = _navion;
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
