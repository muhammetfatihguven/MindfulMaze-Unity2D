using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMoveScript : MonoBehaviour
{
    public static AudioSource audioSource;
    public static float dene;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        
    }
    void Update()
    {
        audioSource.volume = SliderScript.sliderValue;
    }
}
