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
<<<<<<< Updated upstream
    private bool isThunder;
=======
<<<<<<< HEAD
    private bool isThunder;
=======
    public bool isThunder;
>>>>>>> develop
>>>>>>> Stashed changes
    private bool firstThunder = true;
    public fadeBackground fadeBackground;
    public float randomThunderTimerMin = 3;
    public float randomThunderTimerMax = 7;
    private bool randomThunderTimer = true;
<<<<<<< Updated upstream
    public int scoreStartRain;
    
    
=======
<<<<<<< HEAD
    public int scoreStartRain;
    
    
=======
>>>>>>> develop
>>>>>>> Stashed changes
    
    // Start is called before the first frame update
    void Start()
    {
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
>>>>>>> Stashed changes

        rainAudioSource = GetComponent<AudioSource>();
        rainAudioSource.volume = soundControl.sfxVolume;
       
<<<<<<< Updated upstream
=======
=======
        rainAudioSource = GetComponent<AudioSource>();
>>>>>>> develop
>>>>>>> Stashed changes
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
>>>>>>> Stashed changes
        
        if(isThunder){
            rainAudioSource.PlayOneShot(sounds[0]);

             #if UNITY_ANDROID || UNITY_IPHONE 
       Handheld.Vibrate();
#endif
            fadeBackground.screenFlash = true;
            fadeBackground.ScreenFlash();
            
            isThunder = false;
            }
        if(gameController.score >= scoreStartRain && playerScript.tookFlight){
<<<<<<< Updated upstream
=======
=======
        if(isThunder){
            rainAudioSource.PlayOneShot(sounds[0]);
            fadeBackground.screenFlash = true;
            fadeBackground.fadeIn();
            
            isThunder = false;
            }
        if(gameController.score >= 5){
>>>>>>> develop
>>>>>>> Stashed changes
            if(firstThunder){
                isThunder = true;
                firstThunder = false;
            }
<<<<<<< Updated upstream
            
=======
<<<<<<< HEAD
            
=======
>>>>>>> develop
>>>>>>> Stashed changes
            if(randomThunderTimer){
            StartCoroutine("RandomThunder");
            }
            rainDarkEffect.SetActive(true);
            rainEffect.SetActive(true);
            
        }
        else{
<<<<<<< Updated upstream
            randomThunderTimer = true;
            StopAllCoroutines(); 
            firstThunder = true;
=======
<<<<<<< HEAD
            randomThunderTimer = true;
            StopAllCoroutines(); 
            firstThunder = true;
=======
>>>>>>> develop
>>>>>>> Stashed changes
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
