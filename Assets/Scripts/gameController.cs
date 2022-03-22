using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gameController : MonoBehaviour
{
    public TextMeshProUGUI scoreTxt;
    public TextMeshProUGUI hiScoreTxt;
    public static int score;
    public static int highScore;
    private int oldHighScore;
    
    void Start()
    {
        score = 0;
        PlayerPrefs.SetInt("Score", score);
        if(PlayerPrefs.HasKey("HiScore")){
        highScore = PlayerPrefs.GetInt("HiScore");
        }
        }

    // Update is called once per frame
    void Update()
    {
        scoreTxt.text = score.ToString(); // Put the score in the text box
        hiScoreTxt.text = highScore.ToString();
        

    }
    void SaveGame(){
        PlayerPrefs.SetInt("HiScore", highScore);
    }
}
