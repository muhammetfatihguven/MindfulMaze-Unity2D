using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    private static DontDestroy instance = null;

    private void Awake()
    {
        // Check if there is already an instance of this game object in the scene
        if (instance == null)
        {
            // If not, set this instance as the singleton instance
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // If there is already an instance, destroy this game object
            Destroy(gameObject);
        }
    }
}
