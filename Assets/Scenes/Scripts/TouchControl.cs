using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControl : MonoBehaviour
{
    public float slideSpeed = 1.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
    {
        Touch touch = Input.GetTouch(0);
        
        if (touch.phase == TouchPhase.Moved)
        {
            Vector3 touchDeltaPosition = touch.deltaPosition;
            
            // Log the touchDeltaPosition values
            Debug.Log("Touch Delta X: " + touchDeltaPosition.x + ", Touch Delta Y: " + touchDeltaPosition.y);
            
           
        }
    }
    }
}
