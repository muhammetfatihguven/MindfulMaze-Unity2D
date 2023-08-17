using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CharacterScript : MonoBehaviour
{
    public static Rigidbody2D myScriptsRigidbody2D;
    public Canvas canvas;
    public GameObject deneme;
    public static float hesaplama;
    public static float x = 0;
    public float velx = 0;
    public float vely = 0;
    public GameObject Explosion;
    public GameObject Karakter;
    public static bool MovingObjectTouch;
    
    
    
    
    void Start()
    {
    myScriptsRigidbody2D = GetComponent<Rigidbody2D>();
    canvas.enabled = true;
         

        
    }

    public IEnumerator Denemee()
    {
        while (x == 1)
        {
            
        transform.position = new Vector3(deneme.transform.position.x, transform.position.y , transform.position.z);
        yield return null;
        }
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
        ScriptHolder.BlockMultipleRun = 0;
        StopCoroutine(Denemee());
        CharacterMoveScript.audioSource.Play();
         MovingObjectTouch = false;


            
        }
        if (collision.gameObject.CompareTag("Zemin") && vely != 0)
        {
             MovingObjectTouch = true;
             myScriptsRigidbody2D.AddForce(Vector3.zero);
             x = 1;
             
             ScriptHolder.BlockMultipleRun = 0;
            
            StartCoroutine(Denemee());
            CharacterMoveScript.audioSource.Play();
            

            
        }
        if (collision.gameObject.CompareTag("Zemin"))
        {
            MovingObjectTouch = true;
            ScriptHolder.BlockMultipleRun = 0;
            CharacterMoveScript.audioSource.Play();
            
            
            
        } 
        if (collision.gameObject.CompareTag("Dusman"))
        {
            MovingObjectTouch = false;
            CharacterDeathAudio.audioSource.Play();
            ScriptHolder.BlockMultipleRun = 0;
            Instantiate(Explosion, Karakter.transform.position, Quaternion.identity);
            Destroy(gameObject,0.03f);
            FpsScript.starCounts = 0;
            FpsScript.deathCount += 1;
            
        } 
        


    }
    
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Dusman"))
        {
            MovingObjectTouch = false;
            
            ScriptHolder.BlockMultipleRun = 0;
            Instantiate(Explosion, Karakter.transform.position, Quaternion.identity);
            Destroy(gameObject);
            FpsScript.starCounts = 0;
            FpsScript.deathCount += 1;
            
            
        } 
    }

    void Update()
    {
        velx = myScriptsRigidbody2D.velocity.x;
        vely = myScriptsRigidbody2D.velocity.y;
       
        
    }

    
}
