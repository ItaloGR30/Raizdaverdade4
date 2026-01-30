using UnityEngine;

public class EspinhoMortal : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerVida player = collision.gameObject.GetComponent<PlayerVida>();
            if (player != null)
            {
                player.Morrer();
            }
        }
    }
}
