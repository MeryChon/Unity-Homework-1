using UnityEngine;
using UnityEngine.UI;

public class ColorChangeController : MonoBehaviour
{
    [SerializeField]
    private Color _color;
    [SerializeField]
    private Image _backgroundImage;

    private Color _initialColor;
    private float _previousSliderValue;

    public void ChangeCanvasBackground(float colorSliderValue)
    {
        _initialColor = _backgroundImage.color;
        Color targetColor = _initialColor + _color * (colorSliderValue - _previousSliderValue);
        _backgroundImage.color = Color.Lerp(_initialColor, targetColor, 0.5f);
        _previousSliderValue = colorSliderValue;
    }
}
