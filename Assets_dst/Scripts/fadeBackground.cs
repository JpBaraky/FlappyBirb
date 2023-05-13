using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class fadeBackground: MonoBehaviour {
    public GameObject painelFume;
    public Image fume;
    public Color[] corTransicao;
    public float step;
    private bool transition;
    private playerScript playerScript;
    
      void Start()
    {
            playerScript = FindObjectOfType(typeof(playerScript)) as playerScript;   



           painelFume.SetActive(true);

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
        if(playerScript.isDead) {

            playerScript.GameOver();
        }
    }
    IEnumerator FadeO() {
        yield return new WaitForSeconds(0.5f);
        for(float i = 0; i <= 1; i += step) {
            fume.color = Color.Lerp(corTransicao[1],corTransicao[0],i);
            yield return new WaitForEndOfFrame();
        }

        painelFume.SetActive(false);
        transition = false;
    }
    IEnumerator ResetDeath() {
        Debug.Log("teste");
        StartCoroutine("FadeI");
        yield return new WaitForEndOfFrame();
        //StartCoroutine("FadeO");
    }


}