using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public TMP_Text scoreText;
    public TMP_Text highscoreText;

    int score = 0;
    int highscore = 0;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }
        
    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        scoreText.text = "POINTS: " + score;
        highscoreText.text = "HIGHSCORE: " + highscore;
    }

    public void AddScore()
    {
        score++;
        scoreText.text = "POINTS: " + score;

        if (score > highscore)
        {
            highscore = score;
            highscoreText.text = "HIGHSCORE: " + highscore;

            PlayerPrefs.SetInt("highscore", score);
        }
    }
}
