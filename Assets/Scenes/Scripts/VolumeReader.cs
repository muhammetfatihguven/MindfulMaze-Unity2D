using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class VolumeReader : MonoBehaviour
{
        public TextMeshProUGUI Text;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        float SliderValue1 = SliderScript.sliderValue * 100;
        int SliderValue2 = Mathf.FloorToInt(SliderValue1);
        Text.text = "Volume : "+ SliderValue2.ToString();
    }
}
