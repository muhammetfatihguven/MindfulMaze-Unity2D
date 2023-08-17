using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovingScriptLeft : MonoBehaviour
{
    public float moveSpeed = 4f;
    public float nextActionTime = 0.0f;
    public float period = 0.1f;
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

        if (Time.time > nextActionTime ) {
        nextActionTime += period;
         moveLeft = !moveLeft;

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
