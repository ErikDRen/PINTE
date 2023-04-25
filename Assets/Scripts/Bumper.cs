using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    [SerializeField] float jumpForceY;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Rigidbody>().AddForce(new Vector3(0f, jumpForceY, 0f), ForceMode.Impulse);
        //_rigidbody.AddForce(new Vector3(0f, jumpForceY, 0f));
    }
}
