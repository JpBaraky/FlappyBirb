using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class playerData{
    public int playerHiScore;
    public float musicVolume;
    public float sfxVolume;

    
    public playerData(gameController player){
        playerHiScore = player.highScore; 
        musicVolume = player.musicVolume;
        sfxVolume = player.sfxVolume;
       

    }
}
