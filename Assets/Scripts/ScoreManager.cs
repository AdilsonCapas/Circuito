using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text scoreText;
    private int score = 0;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void AddPoints(int points)
    {
        score += points;
        scoreText.text = "Score: " + score;
    }
}
