using UnityEngine;
using UnityEngine.UI;

public class ColorChangeController : MonoBehaviour {
    [SerializeField]
    private Image _cube;
    [SerializeField]
    private Color _color;
    [SerializeField]
    private bool _isUpperColor;
    //[SerializeField]
    private Color _initialColor;
    [SerializeField]
    private string _colorSymbol;

    private float _initialSliderValue;

    private float _previousSliderValue = 0;
    private float _colorInterpolationT = 1;

    void Start () {
        Slider slider = gameObject.GetComponent<Slider>();
        _initialColor = _cube.color;
        if (_colorSymbol == "r")
        {
            Debug.Log("Adding red " + _initialColor.r);
            slider.value = _initialColor.r;
            //UpdateColor(_initialColor.r);
        }
        else if (_colorSymbol == "g")
        {
            Debug.Log("Adding green " + _initialColor.g);
            slider.value = _initialColor.g;
        }
        else if (_colorSymbol == "b")
        {
            Debug.Log("Adding blue " + _initialColor.b);
            slider.value = _initialColor.b;
        }
        _previousSliderValue = slider.value;
        _colorInterpolationT = 0.5f;
	}

    public void UpdateColor(float sliderValue)
    {
        _initialColor = _cube.color;
        Color targetColor = _initialColor + _color * (sliderValue - _previousSliderValue);
        Color newColor = Color.Lerp(_initialColor, targetColor, _colorInterpolationT);
        Debug.Log("Color of sphere was " + _cube.color);
        _cube.color = newColor;
        Debug.Log("New color of sphere is " + _cube.color);
        /*if(_isUpperColor)
        {
            _rectangle.GetComponent<Renderer>().material.SetColor("_UpperColor", newColor);
        } else
        {
            _rectangle.GetComponent<Renderer>().material.SetColor("_BottomColor", newColor);
        } */

        _previousSliderValue = sliderValue;
    }
}
