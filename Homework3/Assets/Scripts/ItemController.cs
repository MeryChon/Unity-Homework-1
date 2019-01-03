using System;
using UnityEngine;
using UnityEngine.UI;

public class ItemController : MonoBehaviour {
    [SerializeField]
    private Text _textField;

    [SerializeField]
    private RectTransform _contentTransform;

    public void Initialize(int index, Action callback)
    {
        _textField.text = "Item " + (index+1).ToString();
    }

    public void DestroyItem()
    {
        Destroy(gameObject);
    }
}
