using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public float initialValue = 0f; // Initial value of the score
    public float increaseRate = 1f; // Rate at which the score increases per second

    private float currentScore; // Current score value
    public Text scoreText; // Reference to the UI text component to display the score

    private void Start()
    {
        currentScore = initialValue; // Initialize the score value
        UpdateScoreText(); // Update the UI text to display the initial score
        InvokeRepeating(nameof(IncreaseScore), 1f, 1f); // Start increasing the score every second
    }

    private void IncreaseScore()
    {
        currentScore += increaseRate; // Increase the score
        UpdateScoreText(); // Update the UI text to display the new score
    }

    private void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = currentScore.ToString(); // Update the UI text with the current score value
        }
    }
}
