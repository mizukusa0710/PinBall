using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    private float visiblePosZ = -6.5f;
    private GameObject gameoverText;
    private int score = 0;
    private GameObject scoreText;

    void Start()
    {
        gameoverText = GameObject.Find("GameOverText");
        scoreText = GameObject.Find("ScoreText");
        UpdateScoreText();
    }

    void Update()
    {
        if (transform.position.z < visiblePosZ)
        {
            GameOver();
        }
    }

    void OnCollisionEnter(Collision other)
    {
        int scoreToAdd = 0;

        switch (other.gameObject.tag)
        {
            case "LargeStarTag":
                scoreToAdd = 20;
                break;
            case "LargeCloudTag":
                scoreToAdd = 10;
                break;
            case "SmallStarTag":
                scoreToAdd = 30;
                break;
            case "SmallCloudTag":
                scoreToAdd = 15;
                break;
            default:
                scoreToAdd = 0;
                break;
        }

        AddScore(scoreToAdd);
    }

    void AddScore(int scoreToAdd)
    {
        score += scoreToAdd;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        scoreText.GetComponent<Text>().text = "Score: " + score;
    }

    void GameOver()
    {
        gameoverText.GetComponent<Text>().text = "Game Over";
        scoreText.GetComponent<Text>().text = "Score: " + score;
    }
}