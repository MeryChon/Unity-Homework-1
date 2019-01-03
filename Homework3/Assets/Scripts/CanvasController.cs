using UnityEngine;
using UnityEngine.UI;

public class CanvasController : MonoBehaviour {
    [SerializeField]
    private Slider _healthSlider;
    [SerializeField]
    private Slider _redSlider;
    [SerializeField]
    private Slider _greenSlider;
    [SerializeField]
    private Slider _blueSlider;
    [SerializeField]
    private RectTransform _scrollViewContent;


    public void OnRestartButtonClick()
    {
        //Reset slider values
        _healthSlider.value = 0.5f;
        _redSlider.value = 0;
        _greenSlider.value = 0;
        _blueSlider.value = 0;
        //Remove all items from scroll view
        for(int i=0; i<_scrollViewContent.childCount; i++)
        {
            GameObject child = _scrollViewContent.GetChild(i).gameObject;
            Destroy(child);
        }
        //Reset child index
        _scrollViewContent.GetComponent<TaskListController>().ResetItemCounter();
    }
}
