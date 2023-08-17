using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;



public class TextScript : MonoBehaviour
{
    public static string BolumSeviyesi;
    public static TextMeshProUGUI textComponent;

    void Start()
    {
         textComponent = GetComponent<TextMeshProUGUI>();

        
    }

    // Update is called once per frame
    void Update()
    {
        textComponent.text = SceneManager.GetActiveScene().name;
        BolumSeviyesi = textComponent.text;

        
        
    }
}
