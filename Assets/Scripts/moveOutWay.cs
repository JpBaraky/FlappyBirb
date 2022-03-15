using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveOutWay : MonoBehaviour
{
    private Animator objectAnimator;
    private bool gameStart;
    private Transform thisTransform;

    // Start is called before the first frame update
    void Start()
    {
        objectAnimator = GetComponent<Animator>();
        thisTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerScript.tookFlight) {
            objectAnimator.SetBool("GameStart",true);

        } else {
            thisTransform.position = new Vector3(-1.45f,0.45f,0);
            objectAnimator.SetBool("GameStart",false);
        }
        
    }
}
