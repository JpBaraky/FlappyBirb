using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class changeScene : MonoBehaviour
{
    public string targetScene;
    public bool isChangeScene;
    public float secondsToWait;
    private fadeBackground fadeBackground;
    public playerScript playerScript;
    private float oldIncrement;
    
    // Start is called before the first frame update
    void Start()
    {
       fadeBackground = FindObjectOfType(typeof(fadeBackground)) as fadeBackground;
    }

    // Update is called once per frame
    void Update()
    {
        if( SceneManager.GetActiveScene().name == "GameScene 1"){
            if(playerScript == null){
               playerScript = FindObjectOfType(typeof(playerScript)) as playerScript;
            }
        }
        if(catOutOfBox.catIsOut) {
            catOutOfBox.catIsOut = false;
         StartCoroutine("changeSceneFadeOut");
        }
        
    }
     IEnumerator changeSceneFadeOut() {
        yield return new WaitForSecondsRealtime(secondsToWait);
        fadeBackground.fadeIn();
        yield return new WaitWhile(() => fadeBackground.fume.color.a < 0.9f);
        yield return new WaitForEndOfFrame();        
         SceneManager.LoadScene(targetScene);
         if(SceneManager.GetActiveScene().name == "GameScene 1"){             
             playerScript.GameOver();
         }
    }
    public void ChangeScene(string sceneToLoad){
        targetScene = sceneToLoad;
        StartCoroutine("changeSceneFadeOut");
        if (SceneManager.GetActiveScene().name == "GameScene 1"){
        
        GameObject[] objects = GameObject.FindGameObjectsWithTag("Destroy");
        foreach(GameObject destroyObject in objects){
        GameObject.Destroy(destroyObject);
        }
        
        }
    }
    
}