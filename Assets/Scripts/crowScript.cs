using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crowScript : MonoBehaviour
{
    private Rigidbody2D crowRigidBody;
    public float driftSpeed;
    // Start is called before the first frame update
    void Start()
    {
        crowRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        crowRigidBody.velocity = new Vector2(driftSpeed,0);
    }
}
