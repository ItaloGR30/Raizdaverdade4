using UnityEngine;
using TMPro;

public class PerguntaUI : MonoBehaviour
{
    public static PerguntaUI instance;

    public GameObject painel;
    public TMP_Text perguntaTxt;
    public TMP_Text alt1Txt;
    public TMP_Text alt2Txt;
    public TMP_Text feedbackTxt;

    private TokenPergunta tokenAtual;
    private PlayerMovement player;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        painel.SetActive(false);
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
    }

    public void MostrarPergunta(TokenPergunta token)
    {
        tokenAtual = token;

        painel.SetActive(true);
        perguntaTxt.text = token.pergunta;
        alt1Txt.text = token.alternativa1;
        alt2Txt.text = token.alternativa2;
        feedbackTxt.text = "";
    }

    public void SelecionarResposta(int resposta)
    {
        if (resposta == tokenAtual.respostaCorreta)
        {
            feedbackTxt.text = "✔ Resposta correta!";
            Invoke("FecharPergunta", 1.2f);
        }
        else
        {
            feedbackTxt.text = "✘ Resposta errada!";
        }
    }

    void FecharPergunta()
    {
        painel.SetActive(false);
        player.AtivarMovimento(true);

        Destroy(tokenAtual.gameObject);
    }
}
