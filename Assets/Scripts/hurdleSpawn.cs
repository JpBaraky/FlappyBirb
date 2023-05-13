using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hurdleSpawn : MonoBehaviour
{
    [Header("PreFab Set")]
    public GameObject hurdlePreFab;
    [Header("Spawining Systems")]
    public float spawnRateMin;
    public float spawnRateMax;
    public float positionMin;
    public float positionMax;
    public bool spawning;
    private int position;
    private playerScript playerScript;
    // Start is called before the first frame update
    void Start()
    {
        playerScript = FindObjectOfType(typeof(playerScript)) as playerScript;
    }

    // Update is called once per frame
    void Update()
    {
        
        
         if(playerScript.hurdleSpawing) {
        if(!spawning){
        StartCoroutine("spawnTimer");
        }
         }
        if(playerScript.isDead){                       
            StopAllCoroutines();
            spawning = false;                                  
            }
    }

    // ## Hurdle Spawner with random position and timer ##
    public IEnumerator spawnTimer(){
        spawning = true;
        
        
        yield return new WaitForSeconds(Random.Range(spawnRateMin, spawnRateMax));
        GameObject tempPreFab =  Instantiate(hurdlePreFab) as GameObject;       
       
        tempPreFab.transform.position = new Vector3(transform.position.x, (float)Random.Range(positionMin,positionMax), tempPreFab.transform.position.z);
        
        spawning = false;
    } 
    //##
}
