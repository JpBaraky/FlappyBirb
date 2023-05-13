using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class soundControl : MonoBehaviour
{
  
    public static float sfxVolume;
    private AudioSource audioSource;
    public Slider sfxSlider;
    public Slider MusicSlider; 

    private gameController gameController;
    private bool isSave;
        // Start is called before the first frame update
    void Start()
    {


        gameController = FindObjectOfType(typeof(gameController)) as gameController;
        audioSource = GetComponent<AudioSource>();
        if(saveSystem.LoadHiScore() != null){
        sfxSlider.value = gameController.sfxVolume;
        MusicSlider.value = gameController.musicVolume;
        }



    }
    

    // Update is called once per frame
    void Update()
    {

        if(gameController.resetFunctionCalled){
           sfxSlider.value = gameController.sfxVolume;
        MusicSlider.value = gameController.musicVolume; 
        gameController.resetFunctionCalled = false;
        }
        if(sfxSlider != null){
    sfxVolume = sfxSlider.value;
        }
    }
    public void SaveSoundSettings(){
        
        if(isSave){
        Debug.Log("Sound Saved");
        gameController.sfxVolume = sfxSlider.value;
        gameController.musicVolume = MusicSlider.value;
        gameController.SaveHiScore();
        isSave = false;
        }
        else{
            isSave = true;
        }
        
    }
    
}
