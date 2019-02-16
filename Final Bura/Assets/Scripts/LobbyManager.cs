using UnityEngine;
using UnityEngine.UI;

public class LobbyManager : MonoBehaviour
{

    [SerializeField]
    private GameObject _newRoomWindowPrefab;

    void Start()
    {
        Text playerNameText = transform.Find("PlayerName").gameObject.GetComponent<Text>();
        playerNameText.text = PlayerInfo._playerName;
    }

    public void CreateNewRoomWindow()
    {
        Instantiate(_newRoomWindowPrefab);
    }
}
