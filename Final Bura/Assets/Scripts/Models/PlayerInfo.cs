using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerInfo : NetworkBehaviour
{

    private const int MAX_NUM_CARDS = 5;

    public static string _playerName;
    public static List<Card> _cards = new List<Card>();
    private int _numCurrentCards;
    private int _currentPoints;

    void Awake()
    {
        Object.DontDestroyOnLoad(this);
    }
}
