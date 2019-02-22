using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

    public string _playerName;
    public bool _isMyTurn;
    public int _currentPoints;

    public static List<GameObject> _cardsOnHand = new List<GameObject>();
    public static List<GameObject> _cardsLaidDown = new List<GameObject>();    
    public static int _numCardsLaid = 0;
    

    // Use this for initialization
    void Start () {
        Debug.Log("Hello from local player");
        GameObject playerPointsPanel = GameObject.Find("PlayerPointsPanel");
        GameObject playerNameObj = playerPointsPanel.transform.Find("PlayerName").gameObject;
        TextMeshProUGUI playerNameText = playerNameObj.GetComponent<TextMeshProUGUI>();
        playerNameText.text = _playerName;

        GameObject gameTablePanel = GameObject.Find("GameTablePanel");

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
