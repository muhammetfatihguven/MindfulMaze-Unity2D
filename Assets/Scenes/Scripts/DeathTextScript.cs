using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class DeathTextScript : MonoBehaviour
{
    public static TextMeshProUGUI DeathtextComponent;

    void Start()
    {
         DeathtextComponent = GetComponent<TextMeshProUGUI>();
         
         DeathtextComponent.text = "Your Death Count: " + FpsScript.deathCount;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
