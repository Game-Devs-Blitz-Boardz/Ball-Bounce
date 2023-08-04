using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;

    void Awake() {
        instance = this;
    }

    public void Restart() {
        SceneManager.LoadScene("Game");
    }
}
