using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
     [Header("Movement Systems")]
    public float jumpForce;
    private Rigidbody2D playerRb;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        FlapWing();
    }
    void FlapWing(){
        if (Input.GetMouseButtonDown(0)){
            playerRb.AddForce(new Vector2(0, jumpForce));
        }
    }
  
} 
