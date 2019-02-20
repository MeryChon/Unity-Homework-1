using UnityEngine;
using UnityEngine.Networking;

public class SetupLocalPlayer : NetworkBehaviour {

	// Use this for initialization
	void Start () {
		if(isLocalPlayer)
        {
            //TODO: enable player controller script
            GetComponent<LocalPlayerController>().enabled = true;
        }
	}

}
