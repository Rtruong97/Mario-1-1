using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoombaWalk : MonoBehaviour {

    public LayerMask enemyMask;
    Rigidbody2D myBody;
    Transform myTrans;
    float myWidth;
    private float speed;



    // Use this for initialization
    void Start () {
        myTrans = this.transform;
        myBody = this.GetComponent<Rigidbody2D>();
        myWidth = this.GetComponent<SpriteRenderer>().bounds.extents.x;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Vector2 lineCastPos = myTrans.position - myTrans.right * myWidth;

        Vector2 myVel = myBody.velocity;
        myVel.x = speed;
        myBody.velocity = myVel;
 


	}
}
