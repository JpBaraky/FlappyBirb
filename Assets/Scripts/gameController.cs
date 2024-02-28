using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class gameController : MonoBehaviour
{
    public TextMeshProUGUI scoreTxt;
    public TextMeshProUGUI hiScoreTxt;
    public static int score;
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
>>>>>>> Stashed changes
    public int highScore;
    public float sfxVolume;

    public float musicVolume;
    private int oldHighScore;
    public static bool resetFunctionCalled;

    
   
    void Start()
    {
        LoadHiScore();
    }
=======
    public static int highScore;
    private int oldHighScore;
    
    void Start()
    {
        
        if(PlayerPrefs.HasKey("HiScore")){
        highScore = PlayerPrefs.GetInt("HiScore");
        }
        }
>>>>>>> develop

    // Update is called once per frame
    void Update()
    {
        if( SceneManager.GetActiveScene().name == "GameScene 1"){
        if(scoreTxt == null && hiScoreTxt == null){
            TMPro.TextMeshProUGUI score = GameObject.Find("ScoreText").GetComponent<TMPro.TextMeshProUGUI>();
            scoreTxt = score;
            TMPro.TextMeshProUGUI hiScore = GameObject.Find("HiScoreText").GetComponent<TMPro.TextMeshProUGUI>();
            hiScoreTxt = hiScore;
        }
        else{
        scoreTxt.text = score.ToString(); // Put the score in the text box
        hiScoreTxt.text = highScore.ToString();
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
>>>>>>> Stashed changes
        }
        
        }
        
       
        

    }
    
    public void SaveHiScore(){
       
        saveSystem.SaveHiScore(this);
    }
    public void LoadHiScore(){
        playerData data = saveSystem.LoadHiScore();
        highScore = data.playerHiScore;
        sfxVolume = data.sfxVolume;
        musicVolume = data.musicVolume;
      
    }
    public void ResetData(){
        resetFunctionCalled = true;
        highScore = 0;
        sfxVolume = 0.25f;
        musicVolume = 0.2f;
        SaveHiScore();
<<<<<<< Updated upstream
=======
=======
        

    }
    void SaveGame(){
        PlayerPrefs.SetInt("HiScore", highScore);
>>>>>>> develop
>>>>>>> Stashed changes
    }
}
