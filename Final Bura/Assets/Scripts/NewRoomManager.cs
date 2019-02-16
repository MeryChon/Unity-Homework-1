using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NewRoomManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _roomInfoPrefab;


    public void CreateNewRoom()
    {
        GameObject roomsScrollView = GameObject.Find("RoomsGrid");
        GameObject viewContent = roomsScrollView.transform.Find("Viewport/Content").gameObject;
        if (roomsScrollView != null)
        {
            GameObject roomInfoPanel = InstantiateRoomInfoPanel(viewContent);
            //roomInfoPanel.transform.SetParent(roomsScrollView.transform, false);
        }
        Destroy(gameObject);
    }

    GameObject InstantiateRoomInfoPanel(GameObject parentObject)
    {
        GameObject roomInfo = Instantiate(_roomInfoPrefab, parentObject.transform, false);

        InputField roomNameInput = transform.Find("NewRoomPanel/RoomNameInputField").gameObject.GetComponent<InputField>();
        Debug.Log(roomInfo.transform.Find("RoomName"));
        TextMeshProUGUI roomNameText = roomInfo.transform.Find("RoomName").gameObject.GetComponent<TextMeshProUGUI>();
        if (roomNameInput != null && roomNameInput.text != "")
        {
            roomNameText.text = roomNameInput.text;
        }
        else
        {
            roomNameText.text = "Random room name"; //TODO: set random room name
        }

        Toggle malyutkaToggleInput = transform.Find("NewRoomPanel/MalyutkaToggle").gameObject.GetComponent<Toggle>();
        if (malyutkaToggleInput != null)
        {
            Toggle malyutkaToggle = roomInfo.transform.Find("MalyutkaToggle").gameObject.GetComponent<Toggle>();
            malyutkaToggle.isOn = malyutkaToggleInput.isOn;
        }
        return roomInfo;
    }
}
