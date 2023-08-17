using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starScript : MonoBehaviour
{
    public static int starCount = 0;
    private float startY;           
    private float moveDistance = 0.05f; 
    private float moveSpeed = 0.075f;

    void Start()
    {
        startY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        float newY = startY + Mathf.PingPong(Time.time * moveSpeed, moveDistance);
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }

    void OnTriggerEnter2D(Collider2D Collision)
    {
        Destroy(gameObject);
        FpsScript.starCounts++;
        StarAudioScript.audioSource.Play();
    }
}
