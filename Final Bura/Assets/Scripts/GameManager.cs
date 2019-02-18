using UnityEngine;
using System.Collections.Generic;
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
        GameObject _trumpCard = AddCardToPanel(trumpCardModel, deckPanel);
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
        return card;
    }

    private GameObject GetRandomCard()
    {
        int size = _deck.Count;
        int randomIndex = Random.Range(0, size);
        return _deck[randomIndex];
    }
}

//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

//public class GameManager : MonoBehaviour
//{
//    [SerializeField]
//    private List<GameObject> _deck;
//    [SerializeField]
//    private int _numCardsToDeal;
//    [SerializeField]
//    private List<Sprite> _cardDeck;
//    [SerializeField]
//    private GameObject _cardPrefab;

//    private GameObject _trumpCard;
//    private const int CARD_MODEL_SCALE = 1000;


//    void Start()
//    {
//        GameObject playerCardsPanel = GameObject.FindWithTag("PlayerCardsPanel");
//        //Choose 5 random cards from deck and put them into player panel
//        /*for (int i = 0; i < _numCardsToDeal; i++)
//        {
//            GameObject nextCardModel = GetRandomCard();
//            AddCardToPanel(nextCardModel, playerCardsPanel);
//            _deck.Remove(nextCardModel);
//        }*/

//        //Choose trump card
//        Sprite trumpCardSprite = GetRandomCard();
//        Debug.Log(trumpCardSprite);
//        GameObject deckPanel = GameObject.FindWithTag("DeckPanel");
//        GameObject _trumpCard = AddCardToPanel(trumpCardSprite, deckPanel);
//        //TODO: _cardDeck.Remove(trumpCardModel);        
//    }


//    private Sprite GetRandomCard()
//    {
//        int size = _cardDeck.Count;
//        int randomIndex = Random.Range(0, size);
//        return _cardDeck[randomIndex];
//    }

//    private GameObject AddCardToPanel(Sprite cardSprite, GameObject panel)
//    {
//        GameObject cardGameObject = Instantiate(_cardPrefab, panel.transform);
//        Debug.Log("object instantiated ", cardGameObject);
//        Card c = cardGameObject.GetComponent<Card>();
//        string cardName = cardSprite.name;
//        string rankCharacter = cardName[0].ToString();
//        string suitCharacter = cardName[1].ToString();
//        c.SetSuit(suitCharacter);
//        c.SetRank(rankCharacter);

//        Debug.Log("set card info" + cardGameObject.GetComponent<Card>().GetSuit());

//        SpriteRenderer sRenderer = cardGameObject.GetComponent<SpriteRenderer>();
//        sRenderer.sprite = cardSprite;

//        cardGameObject.transform.SetParent(panel.transform, false);
//        cardGameObject.AddComponent<LayoutElement>();

//        //GameObject card = Instantiate(cardSprite, panel.transform);
//        //Transform cardTransform = card.transform;
//        //cardTransform.localScale = cardTransform.localScale * CARD_MODEL_SCALE;
//        //cardTransform.eulerAngles = new Vector3(180f, 0f, 0f);
//        //cardTransform.SetParent(panel.transform, false);
//        //card.AddComponent<LayoutElement>();
//        return cardGameObject;
//    }

//}
