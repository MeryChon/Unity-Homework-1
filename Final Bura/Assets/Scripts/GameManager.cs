using System.Linq;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    [SerializeField]
    private List<GameObject> _deck;
    [SerializeField]
    private int _numCardsToDeal;

    private GameObject _trumpCardCode;
    

	void Start () {
        //Choose trump card
        _trumpCardCode = GetRandomCardCode();
        _deck.Remove(_trumpCardCode);
        Debug.Log("Trump card is " + _trumpCardCode);

        GameObject playerCardsPanel = GameObject.FindWithTag("PlayerCardsPanel");
        //Choose 5 random cards from deck and put them into player panel
        for (int i=0; i<_numCardsToDeal; i++)
        {
            GameObject nextCard = GetRandomCardCode();
            GameObject card = Instantiate(nextCard, playerCardsPanel.transform);
            Transform cardTransform = card.transform;
            cardTransform.localScale = cardTransform.localScale * 1000;
            cardTransform.eulerAngles = new Vector3(180f, 0f, 0f);
            cardTransform.SetParent(playerCardsPanel.transform, false);
            LayoutElement elem = card.AddComponent<LayoutElement>();

            _deck.Remove(nextCard);
        }
	}

    private GameObject GetRandomCardCode()
    {    
        int size = _deck.Count;
        int randomIndex = Random.Range(0, size);
        return _deck[randomIndex];
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
