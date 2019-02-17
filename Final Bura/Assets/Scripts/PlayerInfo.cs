using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerInfo : NetworkBehaviour
{

    private const int MAX_NUM_CARDS = 5;

    public static string _playerName;
    public static List<string> _cards = new List<string>();
    public static int _numCurrentCards;

    void Awake()
    {
        Object.DontDestroyOnLoad(this);
    }
}
