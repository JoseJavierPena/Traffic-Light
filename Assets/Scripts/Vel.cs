using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vel : MonoBehaviour
{
    public SliderTimer slider;
    public Slider slide;

    public void Slow()
    {
        slider.timer = 0.5f;
        slide.value = slider.timer;
    }

    public void Normal()
    {
        slider.timer = 1;
        slide.value = slider.timer;
    }

    public void Fast()
    {
        slider.timer = 3f;
        slide.value = slider.timer;
    }
}
