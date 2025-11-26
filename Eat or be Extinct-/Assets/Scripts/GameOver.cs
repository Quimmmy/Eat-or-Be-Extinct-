using UnityEngine;
using TMPro;

public class GameOverScore : MonoBehaviour
{
    public TMP_Text finalScoreText;

    void Start()
    {
        int lastScore = PlayerPrefs.GetInt("lastScore", 0);
        finalScoreText.text = "SCORE: " + lastScore;
    }
}
