using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverSozinhoParalax : MonoBehaviour 
    {
public float scrollSpeed;
<<<<<<< Updated upstream
public float moveAlone;

private float moveX;
=======
<<<<<<< HEAD
public float moveAlone;

private float moveX;
=======

>>>>>>> develop
>>>>>>> Stashed changes
void Start() {
   
   
}

void Update() {
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
>>>>>>> Stashed changes
   
    //Vector3 velocity = Vector3.zero;
//Vector3 desiredPosition = transform.position + new Vector3(scrollSpeed * incrementalSpeed * playerScript.moveOffSet,0,0);
   // Vector3 smoothPosition = Vector3.SmoothDamp(transform.position,desiredPosition,ref velocity,0.3f);
   // transform.position = smoothPosition;
        moveX = transform.position.x;
        moveX += scrollSpeed * Time.deltaTime * (playerScript.moveOffSet + moveAlone);
        transform.position = new Vector3(moveX, transform.position.y, transform.position.z);
<<<<<<< Updated upstream
=======
=======

    Vector3 velocity = Vector3.zero;
    Vector3 desiredPosition = transform.position + new Vector3(scrollSpeed * playerScript.moveOffSet,0,0);
    Vector3 smoothPosition = Vector3.SmoothDamp(transform.position,desiredPosition,ref velocity,0.3f);
    transform.position = smoothPosition;

>>>>>>> develop
>>>>>>> Stashed changes
}

}