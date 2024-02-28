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
<<<<<<< Updated upstream
    private bool flapButton;
=======
<<<<<<< HEAD
    private bool flapButton;
=======
    
>>>>>>> develop
>>>>>>> Stashed changes
    public static bool tookFlight = false;
    public static bool isDead;
    //private hurdleSpawn hurdleSpawn;
    private fadeBackground fadeBackground;
    public static float moveOffSet;
    private gameController gameController;
    public GameObject tapTap;
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
>>>>>>> Stashed changes
    public GameObject backButton;
    [Header("Audio System")]
    public AudioClip[] sounds;
    public AudioSource playerAudio;
    public static float incrementalSpeed;
    private int stopOffSet;
    
<<<<<<< Updated upstream
=======
=======
    [Header("Audio System")]
    public AudioClip[] sounds;
    private AudioSource playerAudio;
>>>>>>> develop
>>>>>>> Stashed changes
    
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
<<<<<<< Updated upstream
        stopOffSet = 0;
        playerAudio.volume = soundControl.sfxVolume;
=======
<<<<<<< HEAD
        stopOffSet = 0;
        playerAudio.volume = soundControl.sfxVolume;
=======
        moveOffSet = 0;
       
>>>>>>> develop
>>>>>>> Stashed changes
        
       
    }

    // Update is called once per frame
    void Update()
    {
        GameStart();
        incrementalSpeed = ((((float)gameController.score)/100f) + 1);
        moveOffSet =  stopOffSet *( incrementalSpeed);
            
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
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
>>>>>>> Stashed changes
        fadeBackground.ScreenFlash();
        #if UNITY_ANDROID || UNITY_IPHONE 
       Handheld.Vibrate();
#endif


 
<<<<<<< Updated upstream
=======
=======
        fadeBackground.fadeIn();
>>>>>>> develop
>>>>>>> Stashed changes
    
        
               

    }
    void GameStart(){
         if (flapButton){
             if(!tookFlight){
               
                 HideUI();
                 gameController.score = 0;
                animator.SetBool("TookFlight", true);
            moveOffSet = 1f;
            playerRb.constraints = RigidbodyConstraints2D.None;
            playerRb.constraints = RigidbodyConstraints2D.FreezeRotation;
            tookFlight = true;
                playerRb.velocity = new Vector2(0,jumpForce);
                PlaySound();
                animator.SetTrigger("Flap");
<<<<<<< Updated upstream
            stopOffSet = 1; 
                
=======
<<<<<<< HEAD
            stopOffSet = 1; 
                
=======
                tapTap.SetActive(false);
>>>>>>> develop
>>>>>>> Stashed changes
                if(!hurdleSpawing){
            
            hurdleSpawing = true;
            
            }
            }
            else{
                
                flap = true;
         }
            flapButton = false;
         }


    }
    public void GameOver()
	{
        
<<<<<<< Updated upstream
        ShowUI();
=======
<<<<<<< HEAD
        ShowUI();
=======
        tapTap.SetActive(true);
        gameController.hiScoreTxt.gameObject.SetActive(true);
>>>>>>> develop
>>>>>>> Stashed changes
        Debug.Log("Birb Dead");
        if(gameController.score > gameController.highScore){
            gameController.highScore = gameController.score;
            gameController.SaveHiScore();
        }
<<<<<<< Updated upstream
        
=======
<<<<<<< HEAD
        
=======
        gameController.score = 0;
>>>>>>> develop
>>>>>>> Stashed changes
        

        tookFlight = false;
        animator.SetBool("TookFlight",false);


<<<<<<< Updated upstream
        stopOffSet = 0;
=======
<<<<<<< HEAD
        stopOffSet = 0;
=======
        moveOffSet = 0;
>>>>>>> develop
>>>>>>> Stashed changes
        
        playerRb.constraints = RigidbodyConstraints2D.FreezeAll;
        playerTransform.transform.position = new Vector3(-1.45f, 0.311f, 0);

        GameObject[] Hurdles = GameObject.FindGameObjectsWithTag("Hurdle");
        foreach(GameObject hurdle in Hurdles){
        GameObject.Destroy(hurdle);
        }
        
       
        hurdleSpawing = false;
        fadeBackground.fadeOut();
        isDead = false;
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
>>>>>>> Stashed changes

        
    }
    public void PlaySound(){
         playerAudio.pitch = Random.Range(0.5f,2.0f);
         playerAudio.PlayOneShot(sounds[Random.Range(0,3)]);

    }
   
    public void FlapButton(){
        flapButton = true;
    }
    public void HideUI(){
         gameController.hiScoreTxt.gameObject.SetActive(false);
         tapTap.SetActive(false);
        backButton.SetActive(false);
    }
    private void ShowUI(){
        tapTap.SetActive(true);
        backButton.SetActive(true);
        gameController.hiScoreTxt.gameObject.SetActive(true);
<<<<<<< Updated upstream
=======
=======

        
    }
    public void PlaySound(){
         playerAudio.pitch = Random.Range(0.5f,2.0f);
         playerAudio.PlayOneShot(sounds[Random.Range(0,3)]);

>>>>>>> develop
>>>>>>> Stashed changes
    }
   
  
} 
