using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyScript : MonoBehaviour
{
    public GameObject goal;
    public static int keyCount = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(FpsScript.starCounts == 3) 
        {
            goal.SetActive(true);
        }
    }

    void OnTriggerEnter2D(Collider2D Collision)
    {   /*
        if(FpsScript.starCounts == 3) {
        
        Destroy(gameObject);
        KeyAudioScript.audioSource.Play();
        keyCount++; 
        goal.SetActive(true); 
        } */
        
    }
}
