using UnityEngine;
using UnityEngine.EventSystems;


public class CardManager : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Transform _parentToDropOn;
    public Card _cardObject;

    private GameObject _playerCardsPanel;
    private GameObject _gameTablePanel;


    void Start()
    {
        _gameTablePanel = GameObject.FindWithTag("GameTablePanel");
        _playerCardsPanel = GameObject.FindWithTag("PlayerCardsPanel");
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (!_cardObject.IsTrumpCard())
        {
            _parentToDropOn = transform.parent;
            gameObject.transform.SetParent(gameObject.transform.parent.parent);
            GetComponent<CanvasGroup>().blocksRaycasts = false;
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (!_cardObject.IsTrumpCard())
        {
            gameObject.transform.position = eventData.position;
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (!_cardObject.IsTrumpCard())
        {
            transform.SetParent(_parentToDropOn);
            GetComponent<CanvasGroup>().blocksRaycasts = true;
        }
    }

    internal void LayCardDown()
    {
        Suit currentCardSuit = this._cardObject.GetSuit();
        if (PlayerInfo._numCardsLaid == 0 || currentCardSuit == PlayerInfo._currentMoveSuit)
        {
            PlayerInfo._currentMoveSuit = currentCardSuit;
            this._parentToDropOn = _gameTablePanel.transform;
            if (!PlayerInfo.CardAlreadyLaidDown(gameObject))
            {
                PlayerInfo._numCardsLaid++;
                PlayerInfo._cardsLaidDown.Add(gameObject);
                PlayerInfo._cardsOnHand.Remove(gameObject);
            }
        }
    }

    internal void ReturnCardToHand()
    {
        this._parentToDropOn = _playerCardsPanel.transform;
        if (PlayerInfo.CardAlreadyLaidDown(gameObject))
        {
            PlayerInfo._numCardsLaid--;
            PlayerInfo._cardsLaidDown.Remove(gameObject);
            PlayerInfo._cardsOnHand.Add(gameObject);
        }
    }
}
