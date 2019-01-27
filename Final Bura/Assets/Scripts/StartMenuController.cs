using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuController : MonoBehaviour {

	public void GoToLobby()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        //TODO: Are you sure?
        Application.Quit();
    }
}
