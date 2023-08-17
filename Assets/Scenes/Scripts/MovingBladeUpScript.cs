using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBladeUpScript : MonoBehaviour
{
    public float moveSpeed = 4f;

    [SerializeField]
    private bool moveUp;

    void Update()

    {
        if (moveUp) {
            Vector3 temp = transform.position;
            temp.y -= moveSpeed * Time.deltaTime;
            transform.position = temp;
        } else {
            Vector3 temp = transform.position;
            temp.y += moveSpeed * Time.deltaTime;
            transform.position = temp;
        }
    }
    
    void OnTriggerEnter2D(Collider2D target2)
    {
        if(target2.gameObject.CompareTag("Ground"))
        {
            moveUp = !moveUp;
        }
    }
}
