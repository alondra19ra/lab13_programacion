using UnityEngine;
using TMPro; // Importa TextMeshPro.

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance; // Singleton para acceder desde otros scripts.
    public TextMeshProUGUI scoreText; // Referencia al texto TMP.
    private int score = 0; // Puntuación inicial.

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        UpdateScoreUI();
    }

    public void AddScore(int points)
    {
        score += points;
        UpdateScoreUI();
    }

    private void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Puntuación: " + score;
        }
    }
}

