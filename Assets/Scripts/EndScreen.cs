using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndScreen : MonoBehaviour
{
    public TextMeshProUGUI finalScoreText;
    public ScoreKeeper scoreKeeper;
    private void Start()
    {
        
    }
    public void ShowFinalScore()
    {
        finalScoreText.text = "Congladuation your point is: " + scoreKeeper.CalculateScore() + "%";
    }
}
