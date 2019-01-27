using UnityEngine;
using UnityEngine.SceneManagement;

public class NewRoomManager : MonoBehaviour {

	public void StartNewGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
