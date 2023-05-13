using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundControlCatInTheBox : MonoBehaviour
{
    public AudioSource audioScource;
    public AudioClip[] audios; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlaySound(int wichSound){
        //audioScource.PlayOneShot(audios(wichSound));
    }
    }
