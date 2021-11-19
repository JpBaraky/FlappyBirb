using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public bool dead = false;
     [Header("Movement Systems")]
     Vector3 velocity = Vector3.zero;
     public float forwardSpeed = 1f;
    public float jumpForce;
    private bool flap = false;
    private Rigidbody2D playerRb;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetMouseButtonDown(0)){
             flap = true;
         }
    }
   void FixedUpdate(){
    		

		if(flap) {
			playerRb.AddForce( Vector2.up * jumpForce );
			animator.SetTrigger("Flap");
			flap = false;
		}

	/*	if(playerRb.velocity.y > 0) {
			transform.rotation = Quaternion.Euler(0, 0, 0);
		}
		else {
			float angle = Mathf.Lerp (0, -90, (-playerRb.velocity.y / 3f) );
			transform.rotation = Quaternion.Euler(0, 0, angle);
		} */

   }
    void OnTriggerEnter2D(){
        Debug.Log("Birb Dead");

    }

    
  
} 
