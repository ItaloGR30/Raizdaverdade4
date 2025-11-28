using UnityEngine;

public class PlayerCollect : MonoBehaviour
{
    public int score = 0; // Pontos do jogador
    public ScoreUI scoreUI; // Referência para o UI

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Moeda"))
        {
            score++;
            scoreUI.UpdateScore(score);
            Destroy(collision.gameObject);
        }
    }
}
