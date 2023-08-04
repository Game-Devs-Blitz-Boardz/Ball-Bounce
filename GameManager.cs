using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;

    public TextMeshProUGUI scoreText;
    public int score;

    void Awake() {
        instance = this;
    }

    public void Restart() {
        SceneManager.LoadScene("Game");
    }

    public void ScoreUp() {
        score++;
        scoreText.text = score.ToString();
    }
}
