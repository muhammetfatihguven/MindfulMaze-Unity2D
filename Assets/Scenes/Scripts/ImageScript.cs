using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageScript : MonoBehaviour
{
      public SpriteRenderer spriteRenderer;
      public Sprite newSprite;
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    { 
        if(keyScript.keyCount == 1)
        {
           spriteRenderer.sprite = newSprite;
        }
    }
}
