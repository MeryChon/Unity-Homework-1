using System.Collections.Generic;
using UnityEngine.Networking;

public class ServerToClientMessage : MessageBase {

    public bool _isMyTurn;
    public string _trumpCard;
    public string _card1;
    public string _card2;
    public string _card3;
    public string _card4;
    public string _card5;
}
