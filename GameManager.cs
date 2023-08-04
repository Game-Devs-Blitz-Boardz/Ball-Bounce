using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;

    public TextMeshProUGUI scoreText;
    public int score;
    public bool gameStarted = false;
    public GameObject panel;

    void Awake() {
        instance = this;
    }

    void Update() {
        panel.SetActive(!gameStarted);
    }

    public void Restart() {
        SceneManager.LoadScene("Game");
    }

    public void ScoreUp() {
        score++;
        scoreText.text = score.ToString();
    }
}
