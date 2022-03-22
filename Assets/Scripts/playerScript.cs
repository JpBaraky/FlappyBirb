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
    public  bool hurdleSpawing = false;
    
    public static bool tookFlight = false;
    public static bool isDead;
    //private hurdleSpawn hurdleSpawn;
    private fadeBackground fadeBackground;
    public static float moveOffSet;
    private gameController gameController;
    public GameObject tapTap;
    [Header("Audio System")]
    public AudioClip[] sounds;
    private AudioSource playerAudio;
    
    // Start is called before the first frame update
    void Start()
    {
            
        //hurdleSpawn = FindObjectOfType(typeof(hurdleSpawn)) as hurdleSpawn;
        gameController = FindObjectOfType(typeof(gameController)) as gameController;
        fadeBackground = FindObjectOfType(typeof(fadeBackground)) as fadeBackground;
        playerAudio = GetComponent<AudioSource>();
        playerRb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        playerTransform = GetComponent<Transform>();
        playerRb.constraints = RigidbodyConstraints2D.FreezeAll;
        moveOffSet = 0;
       
        
       
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
            PlaySound();
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
            moveOffSet = 1f;
            playerRb.constraints = RigidbodyConstraints2D.None;
            playerRb.constraints = RigidbodyConstraints2D.FreezeRotation;
            tookFlight = true;
                playerRb.velocity = new Vector2(0,jumpForce);
                PlaySound();
                animator.SetTrigger("Flap");
                tapTap.SetActive(false);
                if(!hurdleSpawing){
            
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
        
        tapTap.SetActive(true);
        gameController.hiScoreTxt.gameObject.SetActive(true);
        Debug.Log("Birb Dead");
        if(gameController.score > gameController.highScore){
            gameController.highScore = gameController.score;
        }
        gameController.score = 0;
        

        tookFlight = false;
        animator.SetBool("TookFlight",false);


        moveOffSet = 0;
        
        playerRb.constraints = RigidbodyConstraints2D.FreezeAll;
        playerTransform.transform.position = new Vector3(-1.45f, 0.311f, 0);

        GameObject[] Hurdles = GameObject.FindGameObjectsWithTag("Hurdle");
        foreach(GameObject hurdle in Hurdles){
        GameObject.Destroy(hurdle);
        }
        
       
        hurdleSpawing = false;
        fadeBackground.fadeOut();
        isDead = false;

        
    }
    public void PlaySound(){
         playerAudio.pitch = Random.Range(0.5f,2.0f);
         playerAudio.PlayOneShot(sounds[Random.Range(0,3)]);

    }
   
  
} 
