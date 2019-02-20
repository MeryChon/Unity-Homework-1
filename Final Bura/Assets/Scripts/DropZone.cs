using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler, IPointerDownHandler, IPointerExitHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        CardManager cm = eventData.pointerDrag.GetComponent<CardManager>();
        if (cm != null)
        {
            if(gameObject.transform.tag == "PlayerCardsPanel")
            {
                cm.ReturnCardToHand();
            } else
            {
                cm.LayCardDown();
            }
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
    }

    public void OnPointerExit(PointerEventData eventData)
    {
    }
}
