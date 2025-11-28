using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    public float jumpForce = 8f;
    public float fallMultiplier = 2.5f;
    public float lowJumpMultiplier = 2f;

    private bool podeMover = true;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 2f; // gravidade equilibrada
    }

    void Update()
    {
        if (!podeMover)
        {
            rb.linearVelocity = new Vector2(0, rb.linearVelocity.y);
            return;
        }

        // Movimento horizontal
        float x = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(x * speed, rb.linearVelocity.y);

        // Pular apenas se estiver no chão
        if (Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(rb.linearVelocity.y) < 0.05f)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }

        // Deixar o pulo mais bonito (queda mais rápida + pulo variável)
        if (rb.linearVelocity.y < 0)
        {
            // Caindo → aumenta gravidade
            rb.linearVelocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }
        else if (rb.linearVelocity.y > 0 && !Input.GetKey(KeyCode.Space))
        {
            // Soltou o espaço antes de chegar ao topo → pulo menor
            rb.linearVelocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
        }
    }

    public void AtivarMovimento(bool estado)
    {
        podeMover = estado;
        if (!estado) rb.linearVelocity = Vector2.zero;
    }
}
