using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class fadeBackground: MonoBehaviour {
    public GameObject painelFume;
    private playerScript playerScript;
    public Image fume;
    public Color[] corTransicao;
    public float step;
    private bool transition;
<<<<<<< Updated upstream
    public float fadeOutTimer = 0.5f;
    public static bool screenFlash;
    
      void Start()
    {
        playerScript = FindObjectOfType(typeof(playerScript)) as playerScript;
            if(painelFume.activeInHierarchy == false){
                painelFume.SetActive(true);
            }
=======
<<<<<<< HEAD
    public float fadeOutTimer = 0.5f;
    public static bool screenFlash;
    
      void Start()
    {
        playerScript = FindObjectOfType(typeof(playerScript)) as playerScript;
            if(painelFume.activeInHierarchy == false){
                painelFume.SetActive(true);
            }
=======
    private playerScript playerScript;
    public float fadeOutTimer = 0.5f;
    public bool  screenFlash;
    
      void Start()
    {
           
            playerScript = FindObjectOfType(typeof(playerScript)) as playerScript;   
>>>>>>> develop
>>>>>>> Stashed changes
           
            fadeOut();

        
    }
    public void fadeIn() {
        if(!transition) {
            transition = true;
            painelFume.SetActive(true);

            StartCoroutine("FadeI");
        }
      
    }
    public void fadeOut() {

        
        StartCoroutine("FadeO");


    }
    IEnumerator FadeI() {
        for(float i = 0; i <= 1; i += step) {
            fume.color = Color.Lerp(corTransicao[0],corTransicao[1],i);
            yield return new WaitForEndOfFrame();
        }
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
=======
        if(screenFlash){
            fadeOut();
            screenFlash = false;
        }
>>>>>>> develop
>>>>>>> Stashed changes
        if(playerScript != null){
        if(playerScript.isDead) {

            playerScript.GameOver();
        }
        }
<<<<<<< Updated upstream
        
=======
<<<<<<< HEAD
        
=======
>>>>>>> develop
>>>>>>> Stashed changes
    }
    IEnumerator FadeO() {
        yield return new WaitForSeconds(fadeOutTimer);
        for(float i = 0; i <= 1; i += step) {
            fume.color = Color.Lerp(corTransicao[1],corTransicao[0],i);
            yield return new WaitForEndOfFrame();
        }

        painelFume.SetActive(false);
        transition = false;
    }
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
>>>>>>> Stashed changes

    public void ScreenFlash(){
        StartCoroutine("FlashScreen");
    }
    IEnumerator FlashScreen(){
        fadeIn();
        yield return new WaitWhile(() => fume.color.a < 0.9f);
        fadeOut();
<<<<<<< Updated upstream
=======
=======
    IEnumerator ResetDeath() {
       
        StartCoroutine("FadeI");
        yield return new WaitForEndOfFrame();
        //StartCoroutine("FadeO");
>>>>>>> develop
>>>>>>> Stashed changes
    }
    
    


    
    


    
    


}