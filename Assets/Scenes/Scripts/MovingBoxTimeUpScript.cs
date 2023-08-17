using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MovingBoxTimeUpScript : MonoBehaviour
{
    public float nextActionTime = 4.0f;
    public float period = 1.0f;
    public float moveSpeed = 4f;
    


    [SerializeField]
    private bool moveUp;

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextActionTime ) {
        nextActionTime += period;
        moveUp = !moveUp;
                 

        }




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
