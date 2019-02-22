using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> _deck;
    [SerializeField]
    private int _numCardsToDeal;

    private GameObject _trumpCard;
    private const int CARD_MODEL_SCALE = 9;


    void Start()
    {
        GameObject playerCardsPanel = GameObject.FindWithTag("PlayerCardsPanel");
        //Choose 5 random cards from deck and put them into player panel
        for (int i = 0; i < _numCardsToDeal; i++)
        {
            GameObject nextCardPrefab = GetRandomCard();
            AddCardToPanel(nextCardPrefab, playerCardsPanel, false);
            _deck.Remove(nextCardPrefab);
        }

        //Choose trump card
        GameObject trumpCardPrefab = GetRandomCard();
        GameObject deckPanel = GameObject.FindWithTag("DeckPanel");
        Debug.Log(deckPanel);
        _trumpCard = AddCardToPanel(trumpCardPrefab, deckPanel, true);
        _deck.Remove(trumpCardPrefab);
    }


    private GameObject AddCardToPanel(GameObject cardPrefab, GameObject panel, bool isTrumpCard)
    {
        GameObject card = Instantiate(cardPrefab, panel.transform, false);
        Transform cardTransform = card.transform;

        Card currentCard = new Card(cardTransform.name);
        currentCard.SetIsTrumpCard(isTrumpCard);
        card.GetComponent<CardManager>()._cardObject = currentCard;
        PlayerInfo._cardsOnHand.Add(card);
        //card.AddComponent<LayoutElement>();

        if (isTrumpCard)
        {
            GameInfo._trumpSuit = currentCard.GetSuit();
        }
        
        return card;
    }

    private GameObject GetRandomCard()
    {
        int size = _deck.Count;
        int randomIndex = UnityEngine.Random.Range(0, size);
        return _deck[randomIndex];
    }


    public void OnQuitButtonClick()
    {
        Debug.Log("Quit was clicked");
    }

    public void OnDaviButtonClicked()
    {
        Debug.Log("Davi was proposed");
    }
}