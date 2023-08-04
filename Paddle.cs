using UnityEngine;

public class Paddle : MonoBehaviour
{
    
    Rigidbody2D rb;
    public float moveSpeed;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
    }

    void FixedUpdate() {
        TouchMove();
    }

    void TouchMove() {
        if (Input.GetMouseButton(0)) {
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (touchPos.x < 0) {
                rb.velocity = Vector2.left * moveSpeed;
            } else if (touchPos.x > 0) {
                rb.velocity = Vector2.right * moveSpeed;
            }
        } else {
            rb.velocity = Vector2.zero;
        }
    }
}
