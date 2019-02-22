using UnityEngine;
using UnityEngine.Networking;

public class SetupLocalPlayer : NetworkBehaviour
{
    [SyncVar]
    public string _playerName = "Default name"; //TODO : is sync var correctly used here?

    void Start()
    {
        if (isLocalPlayer)
        {
            PlayerManager playerManager = GetComponent<PlayerManager>();
            playerManager._playerName = _playerName;
            playerManager.enabled = true;            
        }
        CmdSetTrumpSuit("asdasd");
    }

    [Command]
    public void CmdSetTrumpSuit(string trumpSuit)
    {
        Debug.Log("I'm a server");
    }

}
