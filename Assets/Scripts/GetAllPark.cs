using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GetAllPark : MonoBehaviour
{
    private int numberOfPark;
    public int validatePark = 0;
    [SerializeField] TextMeshProUGUI _text;
    // Start is called before the first frame update
    void Start()
    {
        numberOfPark = GameObject.FindGameObjectsWithTag("Park").Length;
        _text.text = "0 / " + numberOfPark;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
