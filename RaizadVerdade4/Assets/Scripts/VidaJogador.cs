using UnityEngine;
using UnityEngine.UI;

public class VidaJogador : MonoBehaviour
{
    public int vida = 3;

    public Image cor1;
    public Image cor2;
    public Image cor3;

    public Sprite cheio;
    public Sprite vazio;

    public static VidaJogador instance;

    private void Awake()
    {
        instance = this;
    }

    public void PerderVida()
    {
        vida--;

        AtualizarCoracoes();

        if (vida <= 0)
        {
            Morrer();
        }
    }

    void AtualizarCoracoes()
    {
        cor1.sprite = vida >= 1 ? cheio : vazio;
        cor2.sprite = vida >= 2 ? cheio : vazio;
        cor3.sprite = vida >= 3 ? cheio : vazio;
    }

    void Morrer()
    {
        Debug.Log("GAME OVER!");
        // Aqui você pode reiniciar fase, mostrar tela, etc.
    }
}
