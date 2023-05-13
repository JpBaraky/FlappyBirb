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
    private Transform playerTransform;
    private bool hurdleSpawing = false;
    public static bool tookFlight = false;
    public bool isDead;
    private hurdleSpawn hurdleSpawn;
    private fadeBackground fadeBackground;
    private moveOffSet moveOffSet;
    private gameController gameController;
    // Start is called before the first frame update
    void Start()
    {
            
        hurdleSpawn = FindObjectOfType(typeof(hurdleSpawn)) as hurdleSpawn;
        gameController = FindObjectOfType(typeof(gameController)) as gameController;
        fadeBackground = FindObjectOfType(typeof(fadeBackground)) as fadeBackground;
        moveOffSet = FindObjectOfType(typeof(moveOffSet)) as moveOffSet;
        playerRb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        playerTransform = GetComponent<Transform>();
        playerRb.constraints = RigidbodyConstraints2D.FreezeAll;
        moveOffSet.offSetSpeed = 0;
        hurdleSpawn.spawning = true;
        
       
    }

    // Update is called once per frame
    void Update()
    {
        GameStart();
        

            
    }
   void FixedUpdate(){
      
       

		if(flap) {
            playerRb.velocity = new Vector2(0, jumpForce);
			animator.SetTrigger("Flap");
			flap = false;
		}
       
    		

		/* if(playerRb.velocity.y > 0) {
            float angle = Mathf.Lerp(0,0,(-playerRb.velocity.y / 3f));
            transform.rotation = Quaternion.Euler(0, 0, angle);
		}
		else {
			float angle = Mathf.Lerp (0, -90, (-playerRb.velocity.y / 3f) );
			transform.rotation = Quaternion.Euler(0, 0, angle);
		} */

   }
    void OnTriggerEnter2D(){
        isDead = true;
        fadeBackground.fadeIn();
        
               

    }
    void GameStart(){
         if (Input.GetMouseButtonDown(0)){
             if(!tookFlight){
                gameController.hiScoreTxt.gameObject.SetActive(false);

                animator.SetBool("TookFlight", true);
            moveOffSet.offSetSpeed = 0.2f;
            playerRb.constraints = RigidbodyConstraints2D.None;
            playerRb.constraints = RigidbodyConstraints2D.FreezeRotation;
            tookFlight = true;
                playerRb.velocity = new Vector2(0,jumpForce);
                animator.SetTrigger("Flap");
                if(!hurdleSpawing){
            hurdleSpawn.spawning = false;
            hurdleSpawing = true;
            }
            }
            else{
                
                flap = true;
         }
            
         }

    }
    public void GameOver()
	{

        gameController.hiScoreTxt.gameObject.SetActive(true);
        Debug.Log("Birb Dead");
        if(gameController.score > gameController.highScore){
            gameController.highScore = gameController.score;
        }
        gameController.score = 0;

        tookFlight = false;
        animator.SetBool("TookFlight",false);


        moveOffSet.offSetSpeed = 0;
        moveOffSet.offSet = 0;
        playerRb.constraints = RigidbodyConstraints2D.FreezeAll;
        playerTransform.transform.position = new Vector3(-1.45f, 0.45f, 0);

        GameObject[] Hurdles = GameObject.FindGameObjectsWithTag("Hurdle");
        foreach(GameObject hurdle in Hurdles){
        GameObject.Destroy(hurdle);

        hurdleSpawn.StopAllCoroutines();
        hurdleSpawn.spawning = true;
        hurdleSpawing = false;
        fadeBackground.fadeOut();
            isDead = false;

        }
    }
   
  
} 
