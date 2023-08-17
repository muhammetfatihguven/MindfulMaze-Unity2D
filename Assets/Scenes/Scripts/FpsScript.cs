using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class FpsScript : MonoBehaviour
{
    public static int reklamsayisi = 1;
    public static int starCounts;
    public static int deathCount;
    public static int BolumDegeri;

    

    void Start()
    {
       Application.targetFrameRate = 75; 
       ScriptHolder.BlockMultipleRun = 0;
       ScriptHolder.MultipleTouch = 0;
       BolumDegeri = PlayerPrefs.GetInt("BolumSayisi");
       if (reklamsayisi%3 == 1)
       {
          
          reklamsayisi+= 1;
          
       }
       else 
       {
          reklamsayisi+= 1;
         
       }
    }

    void Respawn()
    {
          
          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    } 

    
}
