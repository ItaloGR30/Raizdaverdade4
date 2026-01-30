using UnityEngine;

public class AguaMortal : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerVida player = other.GetComponent<PlayerVida>();
            if (player != null)
            {
                player.Morrer();
            }
        }
    }
}
