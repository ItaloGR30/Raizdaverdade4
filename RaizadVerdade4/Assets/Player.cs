using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    private bool podeMover = true;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (!podeMover)
        {
            rb.linearVelocity = Vector2.zero;
            return;
        }

        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        rb.linearVelocity = new Vector2(x, y) * speed;
    }

    public void AtivarMovimento(bool estado)
    {
        podeMover = estado;
    }
}
