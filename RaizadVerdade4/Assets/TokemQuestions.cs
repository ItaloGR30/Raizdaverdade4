using UnityEngine;

public class TokenQuestion : MonoBehaviour
{
    public GameObject perguntaUI; // arraste o painel da pergunta aqui

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            perguntaUI.SetActive(true);  
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            perguntaUI.SetActive(false); 
        }
    }
}
