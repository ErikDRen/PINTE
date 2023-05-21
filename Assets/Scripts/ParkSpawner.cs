using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class ParkSpawner : MonoBehaviour
{

    [SerializeField] GameObject _parkPrefab;
    public static ParkSpawner Instance;
    public List<GameObject> ParkInstance;
    PhotonView _view;


    

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        ParkInstance = new List<GameObject>();
        Transform[] allParks = GetComponentsInChildren<Transform>();
        for (int i = 0; i < allParks.Length-1; i++)
        {
            ParkInstance.Add(PhotonNetwork.Instantiate(_parkPrefab.name, allParks[i].transform.position, Quaternion.identity));
            //ParkInstance[i].SetActive(true);

        }

    }
}
