using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    public Slider slider;
    public static float sliderValue = 100f;

    private void Start()
    {
        // Get reference to the Slider component
        slider = GetComponent<Slider>();

        slider.value = sliderValue;
    }

    private void Update()
    {
        
        sliderValue = slider.value;
        

        
    }
}
