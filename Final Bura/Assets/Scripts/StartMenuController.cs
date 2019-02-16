using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenuController : MonoBehaviour
{

    public void GoToLobby()
    {
        //Save name
        InputField nameInput = transform.Find("PlayerNameInput").gameObject.GetComponent<InputField>();
        PlayerInfo._playerName = nameInput.text;

        //Go to next scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        //TODO: Are you sure?
        Application.Quit();
    }
}
