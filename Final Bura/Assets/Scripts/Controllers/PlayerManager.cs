using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

    public static string _playerName;
    public static List<GameObject> _cardsOnHand = new List<GameObject>();
    public static List<GameObject> _cardsLaidDown = new List<GameObject>();    
    public static int _numCardsLaid = 0;
    public static int _currentPoints;

    // Use this for initialization
    void Start () {
        Debug.Log("Hello from local player");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
