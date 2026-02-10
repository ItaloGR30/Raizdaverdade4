using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{
    // Nome da cena do jogo (coloca exatamente como está no Build Settings)
    public string fase1;

    // Botão JOGAR
    public void Jogar()
    {
        SceneManager.LoadScene(fase1);
    }

    // Botão SAIR
    public void Sair()
    {
        Application.Quit();
        Debug.Log("Saiu do jogo"); // só aparece no editor
    }
}
