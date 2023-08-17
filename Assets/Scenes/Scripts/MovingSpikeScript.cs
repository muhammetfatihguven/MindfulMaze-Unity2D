using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MovingSpikeScript : MonoBehaviour
{
    public float moveSpeed = 4f;
    public float nextActionTime;
    public float period = 1.5f;
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

        if (Time.time > nextActionTime ) {
        nextActionTime += period;
         moveUp = !moveUp;
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
