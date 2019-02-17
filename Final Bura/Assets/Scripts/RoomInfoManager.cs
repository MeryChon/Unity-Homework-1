using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class RoomInfoManager : NetworkBehaviour
{

    private int _numPlayers { get; set; }

       
    public void EnterRoom()
    {
        //TODO: check if number of players < 2
        if(_numPlayers < 2)
        {
            _numPlayers++;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        //TODO:  loading mask until number of players becomes 2 and cards can be distributed
    }
}
