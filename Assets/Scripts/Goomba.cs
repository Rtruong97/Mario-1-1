using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goomba : MonoBehaviour
{
    bool playerHit = true;
    private Animator anim;
    public int EnemySpeed;
    public AudioSource death;
    public AudioSource playerdeath;
    public int XMoveDirection;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, new Vector2(XMoveDirection, 0));
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(XMoveDirection, 0) * EnemySpeed;
        if (hit.distance < 0.5f)
        {
            Flip();
            if (hit.collider.tag =="Player")
            {
                Destroy(hit.collider.gameObject);
                playerdeath.Play();
            }
        }
    }

    void Flip()
    {
        if (XMoveDirection > 0)
        {
            XMoveDirection = -1;
        }
        else
        {
            XMoveDirection = 1;

        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player" && playerHit == true)
        {
            anim.SetBool("isDead", true);
            Debug.Log("Goomba dead");
            Destroy(gameObject);
            death.Play();
        }
    }
}

  