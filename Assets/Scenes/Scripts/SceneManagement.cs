using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public string bolum = "Level1";
    public string BolumSayisi = "Ilerleme Durumu";
    
    public static int n = 1;
    public int x;
    

    void Start()
    {
        
    }
//
    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            n++;
            if (x>FpsScript.BolumDegeri)
            {
               FpsScript.BolumDegeri++;
               PlayerPrefs.SetInt("BolumSayisi", FpsScript.BolumDegeri);
               PlayerPrefs.Save();

            }
            SceneManager.LoadScene(bolum);
            CompleteAudio.audioSource.Play();        

            FpsScript.starCounts = 0;
            
            ScriptHolder.BlockMultipleRun = 0;
            ScriptHolder.MultipleTouch = 0;
            
        }
    }
}
