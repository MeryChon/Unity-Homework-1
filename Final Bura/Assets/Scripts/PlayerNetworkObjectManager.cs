using UnityEngine;
using UnityEngine.Networking;


public class PlayerNetworkObjectManager : NetworkBehaviour
{

    [SerializeField]
    private GameObject _playerInfoPrefab;

    private string _playerName { get; set; }

    void Start()
    {
        if (!isLocalPlayer)
        {
            return;
        }

        CmdSpawnPlayerInfo();
    }

    [Command]
    void CmdSpawnPlayerInfo()
    {
        GameObject playerInfoObj = Instantiate(_playerInfoPrefab);
        NetworkServer.Spawn(playerInfoObj);
    }

    void OnServerConnect(NetworkMessage msg)
    {
        Debug.Log("Server connected " + msg.ToString());
    }

    void OnClientConnect(NetworkMessage msg)
    {
        Debug.Log("Client connected to server: " + msg.conn);
    }
}
