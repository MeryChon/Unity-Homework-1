using UnityEngine;
using UnityEngine.UI;

public class ColorChangeController : MonoBehaviour {
    [SerializeField]
    private GameObject _cube;
    [SerializeField]
    private Color _color;
    [SerializeField]
    private bool _isUpperColor;

    private Color _initialColor = Color.black;
    private float _previousSliderValue;

    void Start () {
        Slider slider = gameObject.GetComponent<Slider>();
        _previousSliderValue = slider.value;
	}

    public void UpdateColor(float sliderValue)
    {
        Material cubeMaterial = _cube.GetComponent<Renderer>().material;
        string colorName = "_Color2";
        if (_isUpperColor)
        {
            colorName = "_Color1";
        }
        _initialColor = cubeMaterial.GetColor(colorName);

        Color targetColor = _initialColor + _color * (sliderValue - _previousSliderValue);
        cubeMaterial.SetColor(colorName, targetColor);
        _previousSliderValue = sliderValue;
    }
}
