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
    private const int CARD_MODEL_SCALE = 1000;


    void Start()
    {
        GameObject playerCardsPanel = GameObject.FindWithTag("PlayerCardsPanel");
        //Choose 5 random cards from deck and put them into player panel
        for (int i = 0; i < _numCardsToDeal; i++)
        {
            GameObject nextCardModel = GetRandomCard();
            AddCardToPanel(nextCardModel, playerCardsPanel);
            _deck.Remove(nextCardModel);
        }

        //Choose trump card
        GameObject trumpCardModel = GetRandomCard();
        GameObject deckPanel = GameObject.FindWithTag("DeckPanel");
        _trumpCard = AddCardToPanel(trumpCardModel, deckPanel);
        _deck.Remove(trumpCardModel);
    }

    private GameObject AddCardToPanel(GameObject cardModel, GameObject panel)
    {
        GameObject card = Instantiate(cardModel, panel.transform);
        Transform cardTransform = card.transform;

        Card currentCard = new Card(cardTransform.name);
        PlayerInfo._cards.Add(currentCard);

        cardTransform.localScale = cardTransform.localScale * CARD_MODEL_SCALE;
        cardTransform.eulerAngles = new Vector3(180f, 0f, 0f);
        cardTransform.SetParent(panel.transform, false);

        card.AddComponent<LayoutElement>();
        card.AddComponent<CardManager>();
        return card;
    }

    private GameObject GetRandomCard()
    {
        int size = _deck.Count;
        int randomIndex = Random.Range(0, size);
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
