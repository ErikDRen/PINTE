using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GetAllPark : MonoBehaviour
{
    private int numberOfPark;
    private int numberOfValidatePark;
    [SerializeField] TextMeshProUGUI _text;
    // Start is called before the first frame update
    void Start()
    {
        numberOfPark = GameObject.FindGameObjectsWithTag("Park").Length;
    }

    // Update is called once per frame
    void Update()
    {
        numberOfValidatePark = GameObject.FindGameObjectsWithTag("ValidePark").Length;
        _text.text = numberOfValidatePark + " / " + numberOfPark;
    }


}
