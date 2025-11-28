using UnityEngine;

public class TokenPergunta : MonoBehaviour
{
    public string pergunta;
    public string alternativa1;
    public string alternativa2;
    public int respostaCorreta; // 1 ou 2

    private bool ativado = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (ativado) return;

        if (other.CompareTag("Player"))
        {
            ativado = true;

            // Bloqueia movimento
            other.GetComponent<PlayerMovement>().AtivarMovimento(false);

            // Envia dados para UI
            PerguntaUI.instance.MostrarPergunta(this);
        }
    }
}
