using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private GameObject _voiture;
    
    void Update()
    {
        if (Input.touchCount > 0) 
        {
            Touch touch = Input.GetTouch(0);
            
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x,touch.position.y,10f));
            Debug.Log(touchPosition);
            Debug.DrawLine(Camera.main.transform.position, touchPosition, Color.red);

            if (touchPosition.x > 2)
            {
                _voiture.transform.Rotate(0f, 1f, 0f);
            }
            //RaycastHit hit;
            // if (Physics.Raycast(touchPosition, Camera.main.transform.forward, out hit, 100))
            // {
            //     Debug.Log(hit.point);
            //     Debug.DrawLine(hit.point, Camera.main.transform.position, Color.red);
            // }


            //transform.position = touchPosition;
        }
    }
}
