using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RotateObj : MonoBehaviour
{
    public Slider rotateSlider;
    public Slider scaleSlider;

    float sliderValueR;
    float sliderValueS;

    void Start()
    {
        scaleSlider.GetComponent<Slider>().value = 0.2f;
    }

    // Update is called once per frame
    void Update()
    {
        sliderValueR = rotateSlider.GetComponent<Slider>().value;
        sliderValueS = scaleSlider.GetComponent<Slider>().value;


        transform.rotation = Quaternion.Euler(-90, sliderValueR * 360, 0);
        transform.localScale = new Vector3(sliderValueS*2, sliderValueS * 2, sliderValueS * 2);

    }
}
