using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterDeathAudio : MonoBehaviour
{
    public static AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        
    }

    void Update()
    {
        audioSource.volume = SliderScript.sliderValue;
    }
}
