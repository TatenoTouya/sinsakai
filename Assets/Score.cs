using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private Text scoreText;
    public int score = 0;

    void Start()
    {
        scoreText = GetComponentInChildren<Text>();
        scoreText.text = "0";
    }

    void Update()
    {
        scoreText.text = score.ToString();
    }

    public void AddScore(int amount)
    {
        score += amount;

        // スコアが3000以上になったらシーンを切り替える
        if (score >= 3000)
        {
            Debug.Log("Score reached 3000! Loading clear scene...");
            if (GameManager.Instance != null)
            {
                Debug.Log("GameManager instance found. Loading clear scene...");
                GameManager.Instance.LoadClearScene();
            }
            else
            {
                Debug.LogWarning("GameManager instance is null. Cannot load clear scene.");
            }
        }
    }
}
