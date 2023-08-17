using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LaserScriptAdd : MonoBehaviour
{
    public float nextActionTime = 0.0f;
    public float period = 1.0f;

    [SerializeField]
    public static bool stateLaser;
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
