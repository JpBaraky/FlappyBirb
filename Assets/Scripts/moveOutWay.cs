using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveOutWay : MonoBehaviour
{
    private Animator objectAnimator;
    
    // Start is called before the first frame update
    void Start()
    {
        objectAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerScript.tookFlight){
            objectAnimator.enabled = true;

        }
    }
}
