using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LaserScript : MonoBehaviour
{
    public float nextActionTime = 4.0f;
    public float period = 1.0f;
    public GameObject laser;
    public bool stateLaser = true;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 

        if (Time.time > nextActionTime ) {
        nextActionTime += period;
        stateLaser = !stateLaser;

        }


     if(stateLaser == true)
     {
          laser.SetActive(true);
     }
     else
     {
          laser.SetActive(false);
     }
     
     
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        nextActionTime = Time.time ;
    }
}
