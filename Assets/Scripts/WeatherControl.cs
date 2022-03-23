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
    public bool isThunder;
    private bool firstThunder = true;
    public fadeBackground fadeBackground;
    public float randomThunderTimerMin = 3;
    public float randomThunderTimerMax = 7;
    private bool randomThunderTimer = true;
    
    // Start is called before the first frame update
    void Start()
    {
        rainAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isThunder){
            rainAudioSource.PlayOneShot(sounds[0]);
            fadeBackground.screenFlash = true;
            fadeBackground.fadeIn();
            
            isThunder = false;
            }
        if(gameController.score >= 5){
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
