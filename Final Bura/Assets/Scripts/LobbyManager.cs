﻿using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class LobbyManager : MonoBehaviour
{

    [SerializeField]
    private GameObject _newRoomCanvas;
    [SerializeField]
    private GameObject _roomInfoPrefab;


    void Start()
    {
        Text playerNameText = transform.Find("PlayerName").gameObject.GetComponent<Text>();
        playerNameText.text = GameInfo._playerName;
    }


    /*
     * Make canvas containing new room creation panel visible
     */
    public void CreateNewRoomWindow()
    {
        _newRoomCanvas.SetActive(true);
    }


    /*
     * Instantiate new room prefab and add it to rooms grid.
     * Hide new room creation canvas.
     */
    public void CreateNewRoom()
    {
        GameObject roomsScrollView = GameObject.Find("RoomsGrid");
        GameObject viewContent = roomsScrollView.transform.Find("Viewport/Content").gameObject;
        InstantiateRoomInfo(viewContent);
        //NetworkServer.Spawn(roomInfo);
        _newRoomCanvas.SetActive(false);
    }



    /*
     * Instantiate new room prefab.
     * Empty input fields in new room creation panel.
     */
    GameObject InstantiateRoomInfo(GameObject parentObject)
    {
        GameObject roomInfo = Instantiate(_roomInfoPrefab, parentObject.transform, false);

        InputField roomNameInput = _newRoomCanvas.transform.Find("NewRoomPanel/RoomNameInputField").gameObject.GetComponent<InputField>();
        TextMeshProUGUI roomNameText = roomInfo.transform.Find("RoomName").gameObject.GetComponent<TextMeshProUGUI>();
        if (roomNameInput != null && roomNameInput.text != "")
        {
            roomNameText.text = roomNameInput.text;
            roomNameInput.text = "";
        }
        else
        {
            roomNameText.text = "Random room name"; //TODO: set random room name
        }

        Toggle malyutkaToggleInput = _newRoomCanvas.transform.Find("NewRoomPanel/MalyutkaToggle").gameObject.GetComponent<Toggle>();
        if (malyutkaToggleInput != null)
        {
            Toggle malyutkaToggle = roomInfo.transform.Find("MalyutkaToggle").gameObject.GetComponent<Toggle>();
            malyutkaToggle.isOn = malyutkaToggleInput.isOn;
            malyutkaToggleInput.isOn = false;
        }
        return roomInfo;
    }

}
