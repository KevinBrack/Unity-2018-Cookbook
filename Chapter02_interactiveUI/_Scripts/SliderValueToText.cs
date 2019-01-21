using UnityEngine;
using UnityEngine.UI;

public class SliderValueToText : MonoBehaviour
{
    public Slider sliderUI;
    private Text textSliderValue;

    void Awake()
    {
        textSliderValue = GetComponent<Text>();
    }

    void Start()
    {
        ShowSliderValue();
    }

    public void ShowSliderValue()
    {
        string sliderMessage = "Slider Value: " + sliderUI.value;
        textSliderValue.text = sliderMessage;
    }
}
