using TMPro;
using UnityEngine;
using UnityEngine.Networking;

public class SetupLocalPlayer : NetworkBehaviour
{
    [SyncVar]
    public string _currentMoveSuit = "NONE";

    [SyncVar]
    public string _playerName = "Default name"; //TODO : is sync var correctly used here?

    void Start()
    {
        if (isLocalPlayer)
        {
            GetComponent<PlayerManager>().enabled = true;
        }
        CmdSetTrumpSuit("asdasd");
    }

    [Command]
    public void CmdSetTrumpSuit(string trumpSuit)
    {
        Debug.Log("I'm a server");
    }

}
