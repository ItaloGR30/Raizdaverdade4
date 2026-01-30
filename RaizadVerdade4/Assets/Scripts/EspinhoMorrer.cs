using UnityEngine;

public class EspinhoMorrer : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerVida>()?.Morrer();
        }
    }
}
