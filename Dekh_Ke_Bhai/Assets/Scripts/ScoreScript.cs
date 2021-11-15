using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    private TextMeshProUGUI scorescript;

    private int score = 0;
    private void Awake()
    {
        scorescript = GetComponent<TextMeshProUGUI>();
    }

    private void Start()
    {
        RefreshUI();
    }

    public void IncressScore(int Incriment)
    {
        score += Incriment;
        RefreshUI();
    }

    private void RefreshUI() // <<--- It is saperate becoz everytime the game restarts the score will start from 0 in start function,
                             // this is the reason you gave the value 0 up there...
    {
        scorescript.text = "" + score; // <<---  You need to add > "" < this coz this takes string, if u dont it'll through error...
    }

}
