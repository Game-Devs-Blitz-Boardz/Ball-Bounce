using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D rb;
    public float bounceForce;
    bool gameStarted = false;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.anyKeyDown && !gameStarted) {
            gameStarted = true;
            StartBounce();
        }
    }

    void StartBounce() {
        Vector2 randomDirection = new Vector2(Random.Range(-1, 1), 1);

        rb.AddForce(randomDirection * bounceForce, ForceMode2D.Impulse);
    }

    void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "FallCheck") {
            GameManager.instance.Restart();
        } else if (other.gameObject.tag == "Paddle") {
            GameManager.instance.ScoreUp();
        }
    }
}
