using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    public TMP_Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        UpdateScore(); 
    }
    private void Update()
    {
        
    }


    void UpdateScore()
    {

        scoreText.text = "Score: " + score;
    }
    public void AddScore(int amount)
    {

        score += amount;
        UpdateScore();

    }
}
