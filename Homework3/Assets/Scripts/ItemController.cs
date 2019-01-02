using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemController : MonoBehaviour {
    [SerializeField]
    private Text _textField;

    [SerializeField]
    private RectTransform _contentTransform;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Initialize(int index, Action callback)
    {
        _textField.text = "Item " + (index+1).ToString();
        RectTransform itemTransform = transform.GetComponent<RectTransform>();
        Debug.Log("Initial position" + itemTransform.position);
        Debug.Log("Height is " + itemTransform.rect.height);

        float height = itemTransform.rect.height;
        Vector3 previousPosition = itemTransform.position;
        itemTransform.position = previousPosition + new Vector3(0, -index * 1.3f);
        Debug.Log("new position " + itemTransform.position);
        //float y = (index - 1) * itemTransform.rect.height;
        //transform.position = new Vector3(transform.position.x, y);
    }
}
