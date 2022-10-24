using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    [SerializeField] int points = 0;
    [SerializeField] TextMeshProUGUI scoreText;


    private void Start()
    {
        scoreText.text = points.ToString();
    }

    public void AddToScore(int pointsToAdd)
    {
        points += pointsToAdd;
        scoreText.text = points.ToString();
    }
}
