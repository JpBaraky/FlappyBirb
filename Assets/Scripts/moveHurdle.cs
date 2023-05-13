using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveHurdle : MonoBehaviour
{
    [Header("Movement Systems")]
    public float hurdleSpeed;
   
    private float hurdleX;

    [Header("Score Systems")]
    public GameObject player;
    public bool score = false;
    // Start is called before the first frame update
    void Start()
    {
        //## Instanciate player for each object that spawns
        player = GameObject.Find("Player") as GameObject;
        //##
        
    }

    // Update is called once per frame
    void Update()
    {
    
        if(player == null){
            player = GameObject.Find("Player") as GameObject;
        }
        // ## Hurdle Movement ##
        hurdleX = transform.position.x;
        hurdleX += hurdleSpeed * playerScript.incrementalSpeed * Time.deltaTime;
        transform.position = new Vector3(hurdleX, transform.position.y, transform.position.z);
        // ##---------------##


        // ## Hurdle Destroy ##
        if (hurdleX < -10)
        {
            Destroy(this.gameObject);
        }
        //##
        if (hurdleX < player.transform.position.x && !score)
        {
            score = true;
            gameController.score++;

        }
    }
}
