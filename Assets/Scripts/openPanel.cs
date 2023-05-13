using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openPanel : MonoBehaviour
{
    public Animator animator;
    private bool isOpen;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OpenMenu(){
        if(isOpen){
            isOpen = false;
        }
        else{
            isOpen = true;
        }
        animator.SetBool("IsOpen" , isOpen);
    }
}
