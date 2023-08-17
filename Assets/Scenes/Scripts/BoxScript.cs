using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxScript : MonoBehaviour
{
    public float moveSpeed = 4f;

    [SerializeField]
    private bool moveLeft;
    
    
    void Update()
    {
        if (moveLeft) {
            Vector3 temp = transform.position;
            temp.x -= moveSpeed * Time.deltaTime;
            transform.position = temp;
        } else {
            Vector3 temp = transform.position;
            temp.x += moveSpeed * Time.deltaTime;
            transform.position = temp;
        }
    }

    void OnCollisionEnter2D(Collision2D target) {

          if(target.gameObject.CompareTag("Ground")) {
              moveLeft = !moveLeft;
          }
//
    }
}
