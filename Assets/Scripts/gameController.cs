using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gameController : MonoBehaviour
{
    public TextMeshProUGUI scoreTxt;
    public static int score;
    public static int highScore;
    // Start is called before the first frame update
    void Start()
    {
       // PlayerPrefs.SetInt("Score", score);
    }

    // Update is called once per frame
    void Update()
    {
        scoreTxt.text = score.ToString(); // Put the score in the text box
    }
}
