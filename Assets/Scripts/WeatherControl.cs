using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeatherControl : MonoBehaviour
{
    public GameObject rainEffect;
    public GameObject rainDarkEffect;
    public GameObject thunderEffect;
    private AudioSource rainAudioSource;
    public AudioClip[] sounds;
    private bool isThunder;
    private bool firstThunder = true;
    public fadeBackground fadeBackground;
    public float randomThunderTimerMin = 3;
    public float randomThunderTimerMax = 7;
    private bool randomThunderTimer = true;
    public int scoreStartRain;
    
    
    
    // Start is called before the first frame update
    void Start()
    {

        rainAudioSource = GetComponent<AudioSource>();
        rainAudioSource.volume = soundControl.sfxVolume;
       
    }

    // Update is called once per frame
    void Update()
    {
        
        if(isThunder){
            rainAudioSource.PlayOneShot(sounds[0]);
            Handheld.Vibrate();
            fadeBackground.screenFlash = true;
            fadeBackground.ScreenFlash();
            
            isThunder = false;
            }
        if(gameController.score >= scoreStartRain && playerScript.tookFlight){
            if(firstThunder){
                isThunder = true;
                firstThunder = false;
            }
            
            if(randomThunderTimer){
            StartCoroutine("RandomThunder");
            }
            rainDarkEffect.SetActive(true);
            rainEffect.SetActive(true);
            
        }
        else{
            randomThunderTimer = true;
            StopAllCoroutines(); 
            firstThunder = true;
            rainDarkEffect.SetActive(false);
            rainEffect.SetActive(false);
        }
    }
    IEnumerator RandomThunder(){
            randomThunderTimer = false;
            if(!playerScript.isDead){
            yield return new WaitForSeconds(Random.Range(randomThunderTimerMin, randomThunderTimerMax));            
            isThunder = true;
            }
            randomThunderTimer = true;
        
    }
}
