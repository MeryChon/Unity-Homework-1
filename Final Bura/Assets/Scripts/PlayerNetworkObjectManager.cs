using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class PlayerNetworkObjectManager : NetworkBehaviour
{

    //[SerializeField]
    //private GameObject _playerInfoPrefab;

    private string _playerName
    {
        get
        {
            return _playerName;
        }
    }

    private List<Card> _currentPlayerCards;

    //[SyncVar] //TODO
    public List<Card> _cardsLaidDown;

    private int _currentPoints
    {
        get
        {
            return _currentPoints;
        }
    }
    private int _totalScore
    {
        get
        {
            return _totalScore;
        }
    }


    void Start()
    {
        if (!isLocalPlayer)
        {
            return;
        }

        //CmdSpawnPlayerInfo();
    }

    //[Command]
    //void CmdSpawnPlayerInfo()
    //{
    //    GameObject playerInfoObj = Instantiate(_playerInfoPrefab);
    //    NetworkServer.Spawn(playerInfoObj);
    //}

    void OnServerConnect(NetworkMessage msg)
    {
        Debug.Log("Server connected " + msg.ToString());
    }

    void OnClientConnect(NetworkMessage msg)
    {
        Debug.Log("Client connected to server: " + msg.conn);
    }
}
