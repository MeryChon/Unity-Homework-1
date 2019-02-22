using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerInfo : NetworkBehaviour
{

    private const int MAX_NUM_CARDS = 5;

    public static string _playerName;
    public static List<GameObject> _cardsOnHand = new List<GameObject>();
    public static List<GameObject> _cardsLaidDown = new List<GameObject>();
    public static Suit _currentMoveSuit = Suit.NONE;
    public static int _numCardsLaid = 0;
    public static int _currentPoints;

    void Awake()
    {
        Object.DontDestroyOnLoad(this);
        Debug.Log("Awake in PlayerInfo");
    }

    public static bool CardAlreadyLaidDown(GameObject card)
    {
        int cardIndex = _cardsLaidDown.FindIndex(c => c.Equals(card));
        return cardIndex >= 0;
    }
}
