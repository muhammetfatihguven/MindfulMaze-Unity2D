using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;



public class ScriptHolder : MonoBehaviour
{
    public Canvas canvas;
    public GameObject Karakter;
    public GameObject menu;
    public Rigidbody2D RB2D;
    public static bool ses = true;
    public static float BlockMultipleRun = 0;
    public GameObject TutorialMenu;
    public static int TutorialBlock = 0;
    public static int MultipleTouch = 0;
    
    

    void Start()
    {
            RB2D = Karakter.GetComponent<Rigidbody2D>();
            if (TutorialBlock == 1)
            {
              TutorialMenu.SetActive(false);
            }
            else
            {
              TutorialMenu.SetActive(true);
            }
            

    }

    void Update()
    {
       if (Input.GetKeyDown(KeyCode.W))
        {
            YukariGit();
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            SolaGit();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            SagGit();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            AsagiGit();
        }
      
        
        
             if (Input.touchCount > 0)
    {
        Touch touch = Input.GetTouch(0);
        
        if (touch.phase == TouchPhase.Moved)
        {
            Vector3 touchDeltaPosition = touch.deltaPosition;
            
          
           
         if(BlockMultipleRun == 0)
         {

           if (Mathf.Abs(touchDeltaPosition.x) > Mathf.Abs(touchDeltaPosition.y))
           {
              if (touchDeltaPosition.x > touchDeltaPosition.y)
              {
                YukariGit();
              }

              if (touchDeltaPosition.x < touchDeltaPosition.y)
              {
                SolaGit();
              }

           }

           if (Mathf.Abs(touchDeltaPosition.y) > Mathf.Abs(touchDeltaPosition.x))

           {
              if (touchDeltaPosition.y > touchDeltaPosition.x)
              {
                YukariGit();
              }

              if (touchDeltaPosition.y < touchDeltaPosition.x)
              {
                AsagiGit();
              }
           }

         }

           


        }
    }
        
       
    }
    public void SagGit()
    {
      if(MultipleTouch == 0)
      { 
        RB2D.AddForce(new Vector3(340, 0, 0));
        
        
        CharacterScript.x = 0;
        Invoke("DelayedCode", 0.9f);
        Invoke("DelayedCode2", 0.3f);
        BlockMultipleRun = 1;
        MultipleTouch = 1; 
      }
      
       
    
    } 
    public void SolaGit()
    {
      if(MultipleTouch == 0)
      { 
        RB2D.AddForce(new Vector3(-340, 0, 0));
        
        CharacterScript.x = 0;
        Invoke("DelayedCode", 0.9f);
        Invoke("DelayedCode2", 0.3f);
        BlockMultipleRun = 1;
        MultipleTouch = 1; 
      }
      
    }     
    public void YukariGit()
    {
      if(MultipleTouch == 0)
      {
        
        RB2D.AddForce(new Vector3(0, 340, 0));
        
        CharacterScript.x = 0;
        Invoke("DelayedCode", 0.9f);
        Invoke("DelayedCode2", 0.3f);
        BlockMultipleRun = 1;
        MultipleTouch = 1; 
      }
     
    }  
    public void AsagiGit()
    {
      if(MultipleTouch == 0)
      { 
       RB2D.AddForce(new Vector3(0, -340, 0));
        
        
        CharacterScript.x = 0;
        Invoke("DelayedCode", 0.9f);
        Invoke("DelayedCode2", 0.3f);
        BlockMultipleRun = 1;
        MultipleTouch = 1; 
      }
      
      }
  
    public void DelayedCode()
    {
        BlockMultipleRun = 0;
        
    }

    public void DelayedCode2()
    {
        MultipleTouch = 0;
        
    }

    public void pause()
    {
         
         menu.SetActive(true);
         Time.timeScale = 0;
         MenuAudio.audioSource.Play();
    }
    public void Resume()
    {
           menu.SetActive(false);
           Time.timeScale = 1;
           MenuAudio.audioSource.Play();

    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1f;
    }

    public void Restart()
    {

                 MenuAudio.audioSource.Play();
                 
          
          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
          
          FpsScript.starCounts = 0;
          Time.timeScale = 1;
          

    }

    public void SoundChange()
    {
        if(ses) {
                  AudioListener.pause = true;
                  ses = false;
                }
        else 
        {
                  AudioListener.pause = false;
                  ses = true;
        }
        
    }

    public void TutorialMenuClose()
    {
      TutorialMenu.SetActive(false);
      TutorialBlock = 1;
    }
    
}
