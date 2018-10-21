using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillorKilled : MonoBehaviour {
    private bool playerHit;
    private Animator anim;
    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player" && playerHit == true)
        {
            anim.SetBool("isDead", true);
            Debug.Log("Goomba dead");
            Destroy(gameObject);
        }
    }
}
