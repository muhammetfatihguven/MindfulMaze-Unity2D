using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteAudio : MonoBehaviour
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
