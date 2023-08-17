using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bladeScript : MonoBehaviour
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
    
    void OnTriggerEnter2D(Collider2D target2)
    {
        if(target2.gameObject.CompareTag("Ground"))
        {
            moveLeft = !moveLeft;
        }
    }

}
