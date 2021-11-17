using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    private TextMeshProUGUI scorescript;
    //public Text hs;

    private int score = 0;
    private void Awake()
    {
        
        scorescript = GetComponent<TextMeshProUGUI>();
    }

    private void Start()
    {
        //Player.
        RefreshUI();
    }

    private void Update()
    {       
        Highscore();
    }

    public void IncressScore(int Incriment)
    {
        score += Incriment;
        RefreshUI();
    }

    private void RefreshUI() // <<--- It is saperate becoz everytime the game restarts the score will start from 0 in start function,
                             // this is the reason you gave the value 0 up there...
    {
        scorescript.text = score.ToString(); // <<---  You need to add > "" < this coz this takes string, if u dont it'll through error...
    }

    private void Highscore()
    {
        PlayerPrefs.SetInt("highscore", score);
    }

}
