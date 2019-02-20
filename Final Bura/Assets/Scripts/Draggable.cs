using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Transform _parentToDropOn;

    // Use this for initialization
    void Start () {
		
	}

    public void OnBeginDrag(PointerEventData eventData)
    {
        _parentToDropOn = transform.parent;
        gameObject.transform.SetParent(gameObject.transform.parent.parent);

        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        gameObject.transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.SetParent(_parentToDropOn);
        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }
}
