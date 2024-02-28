using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{
    public string targetScene;
    public bool isChangeScene;
    private fadeBackground fadeBackground;
    
    // Start is called before the first frame update
    void Start()
    {
        fadeBackground = FindObjectOfType(typeof(fadeBackground)) as fadeBackground;
    }

    // Update is called once per frame
    void Update()
    {
        if(isChangeScene && Input.anyKeyDown){
         StartCoroutine("changeSceneFadeOut");
        }
        
    }
    public void PassiveInteraction() {
        StartCoroutine("changeSceneFadeOut");
    }
    
    IEnumerator changeSceneFadeOut() {

        fadeBackground.fadeIn();
        yield return new WaitWhile(() => fadeBackground.fume.color.a < 0.9f);
        yield return new WaitForEndOfFrame();
        SceneManager.LoadScene(targetScene);
    }
    
}
