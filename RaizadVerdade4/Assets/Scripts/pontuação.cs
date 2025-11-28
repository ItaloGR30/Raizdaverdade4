using TMPro;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    public TMP_Text scoreText;

    public void UpdateScore(int score)
    {
        scoreText.text = "Pontos: " + score;
    }
}
